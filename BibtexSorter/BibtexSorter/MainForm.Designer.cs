namespace BibtexSorter
{
    partial class MainForm
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
            this.btn_import = new System.Windows.Forms.Button();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.lb_refs = new System.Windows.Forms.ListBox();
            this.tb_export = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(361, 12);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 0;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(13, 14);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(342, 20);
            this.tb_file.TabIndex = 1;
            // 
            // lb_refs
            // 
            this.lb_refs.FormattingEnabled = true;
            this.lb_refs.Location = new System.Drawing.Point(13, 41);
            this.lb_refs.Name = "lb_refs";
            this.lb_refs.Size = new System.Drawing.Size(423, 420);
            this.lb_refs.TabIndex = 2;
            this.lb_refs.MouseDown += this.lb_refs_MouseDown;
            this.lb_refs.DragDrop += this.lb_refs_DragDrop;
            this.lb_refs.DragOver += this.lb_refs_DragOver;
            // 
            // tb_export
            // 
            this.tb_export.Location = new System.Drawing.Point(13, 471);
            this.tb_export.Name = "tb_export";
            this.tb_export.Size = new System.Drawing.Size(342, 20);
            this.tb_export.TabIndex = 4;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(361, 469);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 503);
            this.Controls.Add(this.tb_export);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lb_refs);
            this.Controls.Add(this.tb_file);
            this.Controls.Add(this.btn_import);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.ListBox lb_refs;
        private System.Windows.Forms.TextBox tb_export;
        public System.Windows.Forms.Button btn_export;
    }
}

