using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLForm
{
    public partial class ScriptFrom : Form
    {
        public ScriptFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = $@"DECLARE @bin BINARY (36);
								DECLARE @id VARCHAR(36)
								SET @id = NEWID()
								PRINT @id
								SET @bin = CAST(@id AS BINARY (36));
								PRINT @bin
								SET CONTEXT_INFO @bin

								GO
								IF OBJECT_ID (N'{txtProcName.Text}') IS NOT NULL
									DROP PROC {txtProcName.Text}
								GO
								CREATE PROCEDURE {txtProcName.Text}
								AS
								BEGIN
									{txtContent.Text}
								END
								GO
								BEGIN TRY
									EXEC {txtProcName.Text}
								END TRY
								BEGIN CATCH
									DECLARE @contextInfo VARCHAR(74)
									SET @contextInfo = CAST(CONTEXT_INFO() AS VARCHAR(74))
									DECLARE @groupID UNIQUEIDENTIFIER
									DECLARE @vcGroupID VARCHAR(36)
									DECLARE @errMsg NVARCHAR(MAX)
									SET @vcGroupID = LEFT(@contextInfo,36)
									IF (ASCII(SUBSTRING(@vcGroupID,1,1)) != 0)
									BEGIN
										SET @groupID = @vcGroupID
										SET @errMsg = 'ErrorLine:' + CONVERT(VARCHAR(10),ERROR_LINE()) + ' ErrorMessage:' + ERROR_MESSAGE()
										IF EXISTS(SELECT 1 FROM ScriptManager.dbo.SC_GroupError a WHERE a.GroupID = @groupID)
											DELETE FROM ScriptManager.dbo.SC_GroupError WHERE GroupID = @groupID
										INSERT INTO ScriptManager.dbo.SC_GroupError(GroupID,ErrorMessage) VALUES (@groupID,@errMsg)
										PRINT @errMsg
									END
	
								END CATCH
								SET CONTEXT_INFO 0x0
								DROP PROC {txtProcName.Text}
			";
            ResultForm rfm = new ResultForm(sqlStr);
            rfm.ShowDialog();
        }
    }
}
