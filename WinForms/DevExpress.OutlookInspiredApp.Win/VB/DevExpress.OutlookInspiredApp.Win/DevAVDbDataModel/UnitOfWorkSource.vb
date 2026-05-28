Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.Mvvm.DataModel
#If NET
using DevExpress.Mvvm.DataModel.EFCore;
#Else
Imports DevExpress.Mvvm.DataModel.EF6

#End If
Namespace DevExpress.DevAV.DevAVDbDataModel

    ''' <summary>
    ''' Provides methods to obtain the relevant IUnitOfWorkFactory.
    ''' </summary>
    Public Module UnitOfWorkSource

#If NET
        public static string GetDatabaseFilePath() {
            var filePath = Internal.DataDirectoryHelper.GetFile("devav.sqlite3", Internal.DataDirectoryHelper.DataFolderName);
            try {
                var attributes = File.GetAttributes(filePath);
                if(attributes.HasFlag(FileAttributes.ReadOnly)) {
                    File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
                }
            }
            catch { }
            return filePath;
        }
#End If
        ''' <summary>
        ''' Returns the IUnitOfWorkFactory implementation.
        ''' </summary>
        Public Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork)
#If NET
                () => new DevAVDb(string.Format("Data Source={0}", GetDatabaseFilePath()), MainFormHelper.TakeScreens);
#Else
            Dim contextFactory As Func(Of DevAVDb) = Function() New DevAVDb(MainFormHelper.TakeScreens)
#End If
            Return New DbUnitOfWorkFactory(Of IDevAVDbUnitOfWork)(Function() New DevAVDbUnitOfWork(contextFactory))
        End Function
    End Module
End Namespace
