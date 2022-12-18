
namespace HideButtons
{
    partial class HideButtonsForm
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
            this.topLeftButton = new System.Windows.Forms.Button();
            this.topRightButton = new System.Windows.Forms.Button();
            this.bottomLeftButton = new System.Windows.Forms.Button();
            this.bottomRightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLeftButton
            // 
            this.topLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftButton.Location = new System.Drawing.Point(37, 31);
            this.topLeftButton.Name = "topLeftButton";
            this.topLeftButton.Size = new System.Drawing.Size(125, 125);
            this.topLeftButton.TabIndex = 0;
            this.topLeftButton.Text = "Click Me!";
            this.topLeftButton.UseVisualStyleBackColor = true;
            this.topLeftButton.Click += new System.EventHandler(this.topLeftButton_Click);
            // 
            // topRightButton
            // 
            this.topRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightButton.Location = new System.Drawing.Point(168, 31);
            this.topRightButton.Name = "topRightButton";
            this.topRightButton.Size = new System.Drawing.Size(125, 125);
            this.topRightButton.TabIndex = 1;
            this.topRightButton.Text = "Click Me!";
            this.topRightButton.UseVisualStyleBackColor = true;
            // 
            // bottomLeftButton
            // 
            this.bottomLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftButton.Location = new System.Drawing.Point(37, 162);
            this.bottomLeftButton.Name = "bottomLeftButton";
            this.bottomLeftButton.Size = new System.Drawing.Size(125, 125);
            this.bottomLeftButton.TabIndex = 2;
            this.bottomLeftButton.Text = "Click Me!";
            this.bottomLeftButton.UseVisualStyleBackColor = true;
            // 
            // bottomRightButton
            // 
            this.bottomRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightButton.Location = new System.Drawing.Point(168, 162);
            this.bottomRightButton.Name = "bottomRightButton";
            this.bottomRightButton.Size = new System.Drawing.Size(125, 125);
            this.bottomRightButton.TabIndex = 3;
            this.bottomRightButton.Text = "Click Me!";
            this.bottomRightButton.UseVisualStyleBackColor = true;
            // 
            // HideButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 319);
            this.Controls.Add(this.bottomRightButton);
            this.Controls.Add(this.bottomLeftButton);
            this.Controls.Add(this.topRightButton);
            this.Controls.Add(this.topLeftButton);
            this.Name = "HideButtonsForm";
            this.Text = "Hide Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button topLeftButton;
        private System.Windows.Forms.Button topRightButton;
        private System.Windows.Forms.Button bottomLeftButton;
        private System.Windows.Forms.Button bottomRightButton;
    }
}

