﻿namespace Umbriel.ArcMapUI.UI
{
    partial class AddPhotoPointForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPhotoPointForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.pictureBoxQuickAdd = new System.Windows.Forms.PictureBox();
            this.buttonAddPhotos = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuickAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG Files|*.jpg|All Files|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listViewFiles);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.buttonRemoveAll);
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxQuickAdd);
            this.splitContainer.Panel2.Controls.Add(this.buttonAddPhotos);
            this.splitContainer.Panel2.Controls.Add(this.buttonClose);
            this.splitContainer.Size = new System.Drawing.Size(658, 448);
            this.splitContainer.SplitterDistance = 360;
            this.splitContainer.TabIndex = 1;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.Location = new System.Drawing.Point(0, 0);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(658, 360);
            this.listViewFiles.TabIndex = 1;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listViewFiles_ColumnWidthChanged);
            // 
            // pictureBoxQuickAdd
            // 
            this.pictureBoxQuickAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuickAdd.Image")));
            this.pictureBoxQuickAdd.Location = new System.Drawing.Point(12, 2);
            this.pictureBoxQuickAdd.Name = "pictureBoxQuickAdd";
            this.pictureBoxQuickAdd.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxQuickAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuickAdd.TabIndex = 2;
            this.pictureBoxQuickAdd.TabStop = false;
            this.pictureBoxQuickAdd.Click += new System.EventHandler(this.pictureBoxQuickAdd_Click);
            // 
            // buttonAddPhotos
            // 
            this.buttonAddPhotos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPhotos.Location = new System.Drawing.Point(156, 22);
            this.buttonAddPhotos.Name = "buttonAddPhotos";
            this.buttonAddPhotos.Size = new System.Drawing.Size(107, 38);
            this.buttonAddPhotos.TabIndex = 1;
            this.buttonAddPhotos.Text = "&Add Photos";
            this.buttonAddPhotos.UseVisualStyleBackColor = true;
            this.buttonAddPhotos.Click += new System.EventHandler(this.buttonAddPhotos_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(571, 22);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 38);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveAll.Location = new System.Drawing.Point(276, 23);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(107, 38);
            this.buttonRemoveAll.TabIndex = 3;
            this.buttonRemoveAll.Text = "&Remove All";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // AddPhotoPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 448);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPhotoPointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Photo Point";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddPhotoPointForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddPhotoPointForm_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPhotoPointForm_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuickAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button buttonAddPhotos;
        private System.Windows.Forms.PictureBox pictureBoxQuickAdd;
        private System.Windows.Forms.Button buttonRemoveAll;
    }
}