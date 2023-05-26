using System.ComponentModel;

namespace LanguageEditor.Views
{
    partial class SingleElementView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.diagramControl = new Northwoods.Go.WinForms.DiagramControl();
            this.SuspendLayout();
            // 
            // diagramControl
            // 
            this.diagramControl.BackColor = System.Drawing.Color.White;
            this.diagramControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl.Location = new System.Drawing.Point(0, 0);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.Size = new System.Drawing.Size(522, 319);
            this.diagramControl.TabIndex = 0;
            // 
            // SingleElementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 319);
            this.Controls.Add(this.diagramControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SingleElementView";
            this.ResumeLayout(false);
        }

        private Northwoods.Go.WinForms.DiagramControl diagramControl;

        #endregion
    }
}