namespace Sumulacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.niezmienny_button = new System.Windows.Forms.Button();
            this.glider_button = new System.Windows.Forms.Button();
            this.oscylator_button = new System.Windows.Forms.Button();
            this.random_button = new System.Windows.Forms.Button();
            this.drawGrid = new System.Windows.Forms.Button();
            this.simulationButton = new System.Windows.Forms.Button();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunButton = new System.Windows.Forms.Button();
            this.gunGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPictureBox
            // 
            this.GridPictureBox.Location = new System.Drawing.Point(12, 115);
            this.GridPictureBox.Name = "GridPictureBox";
            this.GridPictureBox.Size = new System.Drawing.Size(727, 490);
            this.GridPictureBox.TabIndex = 0;
            this.GridPictureBox.TabStop = false;
            this.GridPictureBox.Click += new System.EventHandler(this.GridPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szerokość Siatki";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(12, 28);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 4;
            this.widthTextBox.Text = "40";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_button.Location = new System.Drawing.Point(186, 20);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(184, 23);
            this.start_button.TabIndex = 9;
            this.start_button.Text = "Pokaż za X iteracji";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stopButton.Location = new System.Drawing.Point(399, 43);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(184, 23);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Halt";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wysokość siatki";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(12, 75);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 14;
            this.heightTextBox.Text = "40";
            // 
            // niezmienny_button
            // 
            this.niezmienny_button.Location = new System.Drawing.Point(12, 627);
            this.niezmienny_button.Name = "niezmienny_button";
            this.niezmienny_button.Size = new System.Drawing.Size(155, 23);
            this.niezmienny_button.TabIndex = 15;
            this.niezmienny_button.Text = "Niezmienny";
            this.niezmienny_button.UseVisualStyleBackColor = true;
            this.niezmienny_button.Click += new System.EventHandler(this.Niezmienny_button_Click);
            // 
            // glider_button
            // 
            this.glider_button.Location = new System.Drawing.Point(173, 628);
            this.glider_button.Name = "glider_button";
            this.glider_button.Size = new System.Drawing.Size(155, 23);
            this.glider_button.TabIndex = 16;
            this.glider_button.Text = "Glider";
            this.glider_button.UseVisualStyleBackColor = true;
            this.glider_button.Click += new System.EventHandler(this.Glider_button_Click);
            // 
            // oscylator_button
            // 
            this.oscylator_button.Location = new System.Drawing.Point(334, 628);
            this.oscylator_button.Name = "oscylator_button";
            this.oscylator_button.Size = new System.Drawing.Size(155, 23);
            this.oscylator_button.TabIndex = 17;
            this.oscylator_button.Text = "Oscylator";
            this.oscylator_button.UseVisualStyleBackColor = true;
            this.oscylator_button.Click += new System.EventHandler(this.Oscylator_button_Click);
            // 
            // random_button
            // 
            this.random_button.Location = new System.Drawing.Point(584, 627);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(155, 24);
            this.random_button.TabIndex = 18;
            this.random_button.Text = "Random";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.Random_button_Click);
            // 
            // drawGrid
            // 
            this.drawGrid.Location = new System.Drawing.Point(801, 28);
            this.drawGrid.Name = "drawGrid";
            this.drawGrid.Size = new System.Drawing.Size(155, 23);
            this.drawGrid.TabIndex = 19;
            this.drawGrid.Text = "Wypełnij siatkę/wyczyść";
            this.drawGrid.UseVisualStyleBackColor = true;
            this.drawGrid.Click += new System.EventHandler(this.DrawGrid_Click);
            // 
            // simulationButton
            // 
            this.simulationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simulationButton.Location = new System.Drawing.Point(399, 20);
            this.simulationButton.Name = "simulationButton";
            this.simulationButton.Size = new System.Drawing.Size(184, 23);
            this.simulationButton.TabIndex = 20;
            this.simulationButton.Text = "Symuluj";
            this.simulationButton.UseVisualStyleBackColor = false;
            this.simulationButton.Click += new System.EventHandler(this.SimulationButton_Click);
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(628, 31);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.intervalTextBox.TabIndex = 21;
            this.intervalTextBox.Text = "800";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "interval";
            // 
            // iterationTextBox
            // 
            this.iterationTextBox.Location = new System.Drawing.Point(228, 49);
            this.iterationTextBox.Name = "iterationTextBox";
            this.iterationTextBox.Size = new System.Drawing.Size(100, 20);
            this.iterationTextBox.TabIndex = 23;
            this.iterationTextBox.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "X:";
            // 
            // gunButton
            // 
            this.gunButton.BackColor = System.Drawing.Color.Red;
            this.gunButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gunButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gunButton.Location = new System.Drawing.Point(801, 115);
            this.gunButton.Name = "gunButton";
            this.gunButton.Size = new System.Drawing.Size(155, 490);
            this.gunButton.TabIndex = 25;
            this.gunButton.Text = "Gilder Gun ";
            this.gunButton.UseVisualStyleBackColor = false;
            this.gunButton.Click += new System.EventHandler(this.GunButton_Click);
            // 
            // gunGameButton
            // 
            this.gunGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunGameButton.Location = new System.Drawing.Point(783, 73);
            this.gunGameButton.Name = "gunGameButton";
            this.gunGameButton.Size = new System.Drawing.Size(184, 23);
            this.gunGameButton.TabIndex = 26;
            this.gunGameButton.Text = "Symuluj Gun Game";
            this.gunGameButton.UseVisualStyleBackColor = false;
            this.gunGameButton.Click += new System.EventHandler(this.GunGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 677);
            this.Controls.Add(this.gunGameButton);
            this.Controls.Add(this.gunButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iterationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.simulationButton);
            this.Controls.Add(this.drawGrid);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.oscylator_button);
            this.Controls.Add(this.glider_button);
            this.Controls.Add(this.niezmienny_button);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridPictureBox);
            this.Name = "Form1";
            this.Text = "Symulacja";
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GridPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button niezmienny_button;
        private System.Windows.Forms.Button glider_button;
        private System.Windows.Forms.Button oscylator_button;
        private System.Windows.Forms.Button random_button;
        private System.Windows.Forms.Button drawGrid;
        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iterationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gunButton;
        private System.Windows.Forms.Button gunGameButton;
    }
}

