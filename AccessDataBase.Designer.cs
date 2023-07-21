namespace Engineeringmanagement2
{
    partial class AccessDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.appData = new Engineeringmanagement2.AppData();
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendeesTableAdapter = new Engineeringmanagement2.AppDataTableAdapters.AttendeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // attendeesBindingSource
            // 
            this.attendeesBindingSource.DataMember = "Attendees";
            this.attendeesBindingSource.DataSource = this.appData;
            // 
            // attendeesTableAdapter
            // 
            this.attendeesTableAdapter.ClearBeforeFill = true;
            // 
            // AccessDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Name = "AccessDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessDataBase";
            this.Load += new System.EventHandler(this.AccessDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private AppData appData;
        private System.Windows.Forms.BindingSource attendeesBindingSource;
        private AppDataTableAdapters.AttendeesTableAdapter attendeesTableAdapter;
    }
}