namespace LanguageEditor.Views
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.metamodelsListView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.modelsListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.metamodelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьМодельНаОсновеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьТрансформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модельмодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модельтекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMetamodelBtn = new System.Windows.Forms.Button();
            this.metamodelContextMenu.SuspendLayout();
            this.modelContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metamodelsListView
            // 
            this.metamodelsListView.HideSelection = false;
            this.metamodelsListView.Location = new System.Drawing.Point(20, 38);
            this.metamodelsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metamodelsListView.MultiSelect = false;
            this.metamodelsListView.Name = "metamodelsListView";
            this.metamodelsListView.Size = new System.Drawing.Size(404, 432);
            this.metamodelsListView.SmallImageList = this.imageList1;
            this.metamodelsListView.TabIndex = 0;
            this.metamodelsListView.UseCompatibleStateImageBehavior = false;
            this.metamodelsListView.View = System.Windows.Forms.View.List;
            this.metamodelsListView.SelectedIndexChanged += new System.EventHandler(this.metamodelsListView_SelectedIndexChanged);
            this.metamodelsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metamodelsListView_MouseClick_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "child.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список метамоделей";
            // 
            // modelsListView
            // 
            this.modelsListView.HideSelection = false;
            this.modelsListView.Location = new System.Drawing.Point(651, 38);
            this.modelsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelsListView.MultiSelect = false;
            this.modelsListView.Name = "modelsListView";
            this.modelsListView.Size = new System.Drawing.Size(399, 432);
            this.modelsListView.SmallImageList = this.imageList1;
            this.modelsListView.TabIndex = 2;
            this.modelsListView.UseCompatibleStateImageBehavior = false;
            this.modelsListView.View = System.Windows.Forms.View.List;
            this.modelsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelsListView_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список моделей";
            // 
            // metamodelContextMenu
            // 
            this.metamodelContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metamodelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.создатьМодельНаОсновеToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.metamodelContextMenu.Name = "metamodelContextMenu";
            this.metamodelContextMenu.Size = new System.Drawing.Size(265, 76);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // создатьМодельНаОсновеToolStripMenuItem
            // 
            this.создатьМодельНаОсновеToolStripMenuItem.Name = "создатьМодельНаОсновеToolStripMenuItem";
            this.создатьМодельНаОсновеToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.создатьМодельНаОсновеToolStripMenuItem.Text = "Создать модель на основе";
            this.создатьМодельНаОсновеToolStripMenuItem.Click += new System.EventHandler(this.создатьМодельНаОсновеToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // modelContextMenu
            // 
            this.modelContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem1,
            this.задатьТрансформациюToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.modelContextMenu.Name = "modelContextMenu";
            this.modelContextMenu.Size = new System.Drawing.Size(254, 76);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // задатьТрансформациюToolStripMenuItem
            // 
            this.задатьТрансформациюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.модельмодельToolStripMenuItem,
            this.модельтекстToolStripMenuItem});
            this.задатьТрансформациюToolStripMenuItem.Name = "задатьТрансформациюToolStripMenuItem";
            this.задатьТрансформациюToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.задатьТрансформациюToolStripMenuItem.Text = "Задать трансформацию...";
            // 
            // модельмодельToolStripMenuItem
            // 
            this.модельмодельToolStripMenuItem.Name = "модельмодельToolStripMenuItem";
            this.модельмодельToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.модельмодельToolStripMenuItem.Text = "модель-модель";
            this.модельмодельToolStripMenuItem.Click += new System.EventHandler(this.модельмодельToolStripMenuItem_Click);
            // 
            // модельтекстToolStripMenuItem
            // 
            this.модельтекстToolStripMenuItem.Name = "модельтекстToolStripMenuItem";
            this.модельтекстToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.модельтекстToolStripMenuItem.Text = "модель-текст";
            this.модельтекстToolStripMenuItem.Click += new System.EventHandler(this.модельтекстToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // CreateMetamodelBtn
            // 
            this.CreateMetamodelBtn.Location = new System.Drawing.Point(20, 479);
            this.CreateMetamodelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateMetamodelBtn.Name = "CreateMetamodelBtn";
            this.CreateMetamodelBtn.Size = new System.Drawing.Size(172, 34);
            this.CreateMetamodelBtn.TabIndex = 4;
            this.CreateMetamodelBtn.Text = "Новая метамодель";
            this.CreateMetamodelBtn.UseVisualStyleBackColor = true;
            this.CreateMetamodelBtn.Click += new System.EventHandler(this.CreateMetamodelBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CreateMetamodelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelsListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metamodelsListView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.metamodelContextMenu.ResumeLayout(false);
            this.modelContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView metamodelsListView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView modelsListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip metamodelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьМодельНаОсновеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip modelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem задатьТрансформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модельмодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модельтекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.Button CreateMetamodelBtn;
    }
}