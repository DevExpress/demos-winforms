Imports System.ComponentModel
Imports DevExpress.XtraDataLayout

#If NET
using DevExpress.AIIntegration.Blazor.Chat;
#End If
Namespace DevExpress.AI.Demos

    Public Partial Class AIChatFileAttachmentsModule
        Inherits AIChatModuleBase

#If NET
        const string IMAGE_NAME = "Eiffel-Tower.jpg";
        const string ICON_NAME = "file.svg";
        Dictionary<FileTypes, List<string>> Extensions = new Dictionary<FileTypes, List<string>>() {
            { FileTypes.Images, new List<string> { ".jpg", ".png", ".jpeg" } },
            { FileTypes.Documents, new List<string> { ".pdf", ".docx" } },
            { FileTypes.Tables, new List<string> { ".xlsx", ".csv" } },
        };
        Dictionary<FileTypes, List<string>> Types = new Dictionary<FileTypes, List<string>>() {
            { FileTypes.Images, new List<string> { "image/jpeg", "image/png" } },
            { FileTypes.Documents, new List<string> { "application/pdf", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" } },
            { FileTypes.Tables, new List<string> { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "text/csv" } },
        };
        public AIChatFileAttachmentsModule() {
            InitializeComponent();
            ChatControl.FileUploadEnabled = Utils.DefaultBoolean.True;
            ChatControl.OptionsFileUpload.MaxFileSize = 10000000;
            ChatControl.OptionsFileUpload.MaxFileCount = 3;
            UpdateAllowedFileTypes();

            var files = new List<AIChatUploadFileInfo>();

            try {
                string path = Path.Combine("Resources", "AIChat", IMAGE_NAME);
                var fileBytes = File.ReadAllBytes(path);
                files.Add(new AIChatUploadFileInfo(
                    name: IMAGE_NAME,
                    type: "image/jpeg",
                    size: fileBytes.Length,
                    data: new ReadOnlyMemory<byte>(fileBytes)
                ));
            } catch { }

            ChatControl.SetMessageTemplate((message) => (builder) => {
                builder.OpenComponent<AIChatFileAttachmentsMessageTemplate>(0);
                builder.AddAttribute(1, "Context", message);
                builder.AddAttribute(2, "ImageExtensions", Extensions[FileTypes.Images]);
                builder.AddAttribute(3, "FileIconBase64", GetFileIconBase64());
                builder.CloseComponent();
            });

            ChatControl.LoadMessages(new[] {
                new BlazorChatMessage(Microsoft.Extensions.AI.ChatRole.User, "Analyze the image file and summarize its content." , files),
                new BlazorChatMessage(Microsoft.Extensions.AI.ChatRole.Assistant, "The image features the Eiffel Tower, a renowned landmark located in Paris, France. The tower is shown from a low angle, emphasizing its height and intricate iron lattice structure. The sky is lit with dramatic clouds and warm hues of sunset, creating a visually striking backdrop for the iconic monument. The overall scene conveys a sense of grandeur and beauty, highlighting the Eiffel Tower as a symbol of romance and architectural achievement.")
            });
        }
        protected override Type GetOptionsType() {
            return typeof(AIChatFileAttachmentsOptions);
        }
        protected new AIChatFileAttachmentsOptions Options => base.Options as AIChatFileAttachmentsOptions;

        protected override void DataLayoutControl_FieldRetrieved(object sender, FieldRetrievedEventArgs e) {
            base.DataLayoutControl_FieldRetrieved(sender, e);
            if(e.FieldName == nameof(Options.SelectedFileType) && e.Control is ComboBoxEdit cbEdit) {
                cbEdit.Properties.Appearance.TextOptions.HAlignment = Utils.HorzAlignment.Near;
            }
        }
        protected override void OptionsPropertyChanged(object sender, PropertyChangedEventArgs e) {
            base.OptionsPropertyChanged(sender, e);
            if(e.PropertyName == nameof(Options.SelectedFileType)) {
                UpdateAllowedFileTypes();
            }
        }
        void UpdateAllowedFileTypes() {
            ChatControl.OptionsFileUpload.FileTypeFilter.Clear();
            ChatControl.OptionsFileUpload.AllowedFileExtensions.Clear();
            ChatControl.OptionsFileUpload.FileTypeFilter.AddRange(Types[Options.SelectedFileType]);
            ChatControl.OptionsFileUpload.AllowedFileExtensions.AddRange(Extensions[Options.SelectedFileType]);
            ChatControl.RefreshChat();
        }
        string GetFileIconBase64() {
            try {
                string root = SafeEnvironment.CurrentDirectory;
                if (string.IsNullOrEmpty(root))
                    return string.Empty;
                string path = Path.Combine(root, "Resources", "AIChat", ICON_NAME);
                if(!SafePath.IsRooted(root, path))
                    return string.Empty;
                var fileBytes = File.ReadAllBytes(path);
                return $"data:image/svg+xml;base64,{Convert.ToBase64String(fileBytes)}";
            } catch {
                return string.Empty;
            }
        }
#End If
    End Class

    Public Class AIChatFileAttachmentsOptions
        Inherits AIChatModuleOptionsBase

#If NET
        FileTypes selectedFileType;
        public FileTypes SelectedFileType {
            get { return selectedFileType; }
            set {
                selectedFileType = value;
                NotifyPropertyChanged(nameof(SelectedFileType));
            }
        }
#End If
    End Class
End Namespace
