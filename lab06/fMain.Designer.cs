namespace lab06
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFormText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFormBinary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gvPhotoAparats = new System.Windows.Forms.DataGridView();
            this.bindSrcPhotoAparats = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhotoAparats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPhotoAparats)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.tsSeparator1,
            this.btnDel,
            this.btnClear,
            this.tsSeparator2,
            this.btnSaveAsText,
            this.btnSaveAsBinary,
            this.btnOpenFormText,
            this.btnOpenFormBinary,
            this.toolStripSeparator1,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 28);
            this.btnAdd.Text = "Додавати запис";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 24);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.MediumOrchid;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(29, 24);
            this.btnDel.Text = "Видалити запис";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(29, 24);
            this.btnClear.Text = "Очистити дані";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsText.Image")));
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(29, 28);
            this.btnSaveAsText.Text = "a";
            this.btnSaveAsText.ToolTipText = "Зберегти у текстовому форматі\r\n";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsBinary.Image")));
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(29, 28);
            this.btnSaveAsBinary.Text = "toolStripButton2";
            this.btnSaveAsBinary.ToolTipText = "Зберегти у бінарному форматі";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnOpenFormText
            // 
            this.btnOpenFormText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFormText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFormText.Image")));
            this.btnOpenFormText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFormText.Name = "btnOpenFormText";
            this.btnOpenFormText.Size = new System.Drawing.Size(29, 28);
            this.btnOpenFormText.Text = "toolStripButton3";
            this.btnOpenFormText.ToolTipText = "Читати в текстовому форматі";
            this.btnOpenFormText.Click += new System.EventHandler(this.btnOpenFormText_Click);
            // 
            // btnOpenFormBinary
            // 
            this.btnOpenFormBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFormBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFormBinary.Image")));
            this.btnOpenFormBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFormBinary.Name = "btnOpenFormBinary";
            this.btnOpenFormBinary.Size = new System.Drawing.Size(29, 28);
            this.btnOpenFormBinary.Text = "toolStripButton4";
            this.btnOpenFormBinary.ToolTipText = "Читати в бінарному форматі";
            this.btnOpenFormBinary.Click += new System.EventHandler(this.btnOpenFormBinary_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 24);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 31);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 419);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gvPhotoAparats
            // 
            this.gvPhotoAparats.AllowUserToAddRows = false;
            this.gvPhotoAparats.AllowUserToDeleteRows = false;
            this.gvPhotoAparats.AutoGenerateColumns = false;
            this.gvPhotoAparats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhotoAparats.DataSource = this.bindSrcPhotoAparats;
            this.gvPhotoAparats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPhotoAparats.Location = new System.Drawing.Point(3, 31);
            this.gvPhotoAparats.Name = "gvPhotoAparats";
            this.gvPhotoAparats.ReadOnly = true;
            this.gvPhotoAparats.RowHeadersWidth = 51;
            this.gvPhotoAparats.RowTemplate.Height = 24;
            this.gvPhotoAparats.Size = new System.Drawing.Size(797, 419);
            this.gvPhotoAparats.TabIndex = 2;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvPhotoAparats);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №5";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.Resize += new System.EventHandler(this.fMain_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhotoAparats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPhotoAparats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingSource bindSrcPhotoAparats;
        private System.Windows.Forms.DataGridView gvPhotoAparats;
        private System.Windows.Forms.ToolStripButton btnSaveAsText;
        private System.Windows.Forms.ToolStripButton btnSaveAsBinary;
        private System.Windows.Forms.ToolStripButton btnOpenFormText;
        private System.Windows.Forms.ToolStripButton btnOpenFormBinary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

