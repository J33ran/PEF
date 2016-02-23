namespace BreakAwayWinForms
{
    partial class Form1
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
            System.Windows.Forms.Label addDateLabel;
            System.Windows.Forms.Label contactIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label modifiedDateLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label initialDateLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label primaryActivityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label secondaryActivityLabel;
            System.Windows.Forms.Label secondaryDestinationLabel;
            System.Windows.Forms.Label primaryDestinationLabel;
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.addDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.modifiedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.initialDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.primaryActivityTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.secondaryActivityTextBox = new System.Windows.Forms.TextBox();
            this.secondaryDestinationTextBox = new System.Windows.Forms.TextBox();
            this.primaryDestinationTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            addDateLabel = new System.Windows.Forms.Label();
            contactIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            modifiedDateLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            initialDateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            primaryActivityLabel = new System.Windows.Forms.Label();
            secondaryActivityLabel = new System.Windows.Forms.Label();
            secondaryDestinationLabel = new System.Windows.Forms.Label();
            primaryDestinationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addDateLabel
            // 
            addDateLabel.AutoSize = true;
            addDateLabel.Location = new System.Drawing.Point(29, 93);
            addDateLabel.Name = "addDateLabel";
            addDateLabel.Size = new System.Drawing.Size(55, 13);
            addDateLabel.TabIndex = 1;
            addDateLabel.Text = "Add Date:";
            // 
            // contactIDLabel
            // 
            contactIDLabel.AutoSize = true;
            contactIDLabel.Location = new System.Drawing.Point(29, 118);
            contactIDLabel.Name = "contactIDLabel";
            contactIDLabel.Size = new System.Drawing.Size(61, 13);
            contactIDLabel.TabIndex = 3;
            contactIDLabel.Text = "Contact ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(28, 144);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(29, 170);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // modifiedDateLabel
            // 
            modifiedDateLabel.AutoSize = true;
            modifiedDateLabel.Location = new System.Drawing.Point(28, 196);
            modifiedDateLabel.Name = "modifiedDateLabel";
            modifiedDateLabel.Size = new System.Drawing.Size(76, 13);
            modifiedDateLabel.TabIndex = 9;
            modifiedDateLabel.Text = "Modified Date:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(28, 222);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Title:";
            // 
            // initialDateLabel
            // 
            initialDateLabel.AutoSize = true;
            initialDateLabel.Location = new System.Drawing.Point(28, 365);
            initialDateLabel.Name = "initialDateLabel";
            initialDateLabel.Size = new System.Drawing.Size(105, 13);
            initialDateLabel.TabIndex = 17;
            initialDateLabel.Text = "Became a Customer:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(28, 391);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 19;
            notesLabel.Text = "Notes:";
            // 
            // primaryActivityLabel
            // 
            primaryActivityLabel.AutoSize = true;
            primaryActivityLabel.Location = new System.Drawing.Point(29, 260);
            primaryActivityLabel.Name = "primaryActivityLabel";
            primaryActivityLabel.Size = new System.Drawing.Size(81, 13);
            primaryActivityLabel.TabIndex = 20;
            primaryActivityLabel.Text = "Primary Activity:";
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(631, 25);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Enabled = false;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // addDateDateTimePicker
            // 
            this.addDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "Contact.AddDate", true));
            this.addDateDateTimePicker.Location = new System.Drawing.Point(139, 93);
            this.addDateDateTimePicker.Name = "addDateDateTimePicker";
            this.addDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.addDateDateTimePicker.TabIndex = 2;
            // 
            // contactIDTextBox
            // 
            this.contactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Contact.ContactID", true));
            this.contactIDTextBox.Location = new System.Drawing.Point(139, 118);
            this.contactIDTextBox.Name = "contactIDTextBox";
            this.contactIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactIDTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Contact.FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(139, 144);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Contact.LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(139, 170);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // modifiedDateDateTimePicker
            // 
            this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "Contact.ModifiedDate", true));
            this.modifiedDateDateTimePicker.Location = new System.Drawing.Point(139, 196);
            this.modifiedDateDateTimePicker.Name = "modifiedDateDateTimePicker";
            this.modifiedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.modifiedDateDateTimePicker.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Contact.Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(139, 222);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 12;
            // 
            // initialDateDateTimePicker
            // 
            this.initialDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "Contact.Customer.InitialDate", true));
            this.initialDateDateTimePicker.Location = new System.Drawing.Point(139, 365);
            this.initialDateDateTimePicker.Name = "initialDateDateTimePicker";
            this.initialDateDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.initialDateDateTimePicker.TabIndex = 18;
            // 
            // primaryActivityTextBox
            // 
            this.primaryActivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PrimaryActivity.Name", true));
            this.primaryActivityTextBox.Location = new System.Drawing.Point(139, 260);
            this.primaryActivityTextBox.Name = "primaryActivityTextBox";
            this.primaryActivityTextBox.Size = new System.Drawing.Size(126, 20);
            this.primaryActivityTextBox.TabIndex = 21;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Contact.Customer.Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(139, 391);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(421, 98);
            this.notesTextBox.TabIndex = 20;
            // 
            // secondaryActivityLabel
            // 
            secondaryActivityLabel.AutoSize = true;
            secondaryActivityLabel.Location = new System.Drawing.Point(296, 264);
            secondaryActivityLabel.Name = "secondaryActivityLabel";
            secondaryActivityLabel.Size = new System.Drawing.Size(98, 13);
            secondaryActivityLabel.TabIndex = 21;
            secondaryActivityLabel.Text = "Secondary Activity:";
            // 
            // secondaryActivityTextBox
            // 
            this.secondaryActivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "SecondaryActivity.Name", true));
            this.secondaryActivityTextBox.Location = new System.Drawing.Point(426, 257);
            this.secondaryActivityTextBox.Name = "secondaryActivityTextBox";
            this.secondaryActivityTextBox.Size = new System.Drawing.Size(134, 20);
            this.secondaryActivityTextBox.TabIndex = 22;
            // 
            // secondaryDestinationLabel
            // 
            secondaryDestinationLabel.AutoSize = true;
            secondaryDestinationLabel.Location = new System.Drawing.Point(296, 292);
            secondaryDestinationLabel.Name = "secondaryDestinationLabel";
            secondaryDestinationLabel.Size = new System.Drawing.Size(117, 13);
            secondaryDestinationLabel.TabIndex = 22;
            secondaryDestinationLabel.Text = "Secondary Destination:";
            // 
            // secondaryDestinationTextBox
            // 
            this.secondaryDestinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "SecondaryDestinations.DestinationName", true));
            this.secondaryDestinationTextBox.Location = new System.Drawing.Point(429, 289);
            this.secondaryDestinationTextBox.Name = "secondaryDestinationTextBox";
            this.secondaryDestinationTextBox.Size = new System.Drawing.Size(131, 20);
            this.secondaryDestinationTextBox.TabIndex = 23;
            // 
            // primaryDestinationLabel
            // 
            primaryDestinationLabel.AutoSize = true;
            primaryDestinationLabel.Location = new System.Drawing.Point(28, 293);
            primaryDestinationLabel.Name = "primaryDestinationLabel";
            primaryDestinationLabel.Size = new System.Drawing.Size(100, 13);
            primaryDestinationLabel.TabIndex = 23;
            primaryDestinationLabel.Text = "Primary Destination:";
            // 
            // primaryDestinationTextBox
            // 
            this.primaryDestinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PrimaryDestinations.DestinationName", true));
            this.primaryDestinationTextBox.Location = new System.Drawing.Point(139, 289);
            this.primaryDestinationTextBox.Name = "primaryDestinationTextBox";
            this.primaryDestinationTextBox.Size = new System.Drawing.Size(126, 20);
            this.primaryDestinationTextBox.TabIndex = 24;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(BAGA.Customer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 501);
            this.Controls.Add(primaryDestinationLabel);
            this.Controls.Add(this.primaryDestinationTextBox);
            this.Controls.Add(secondaryDestinationLabel);
            this.Controls.Add(this.secondaryDestinationTextBox);
            this.Controls.Add(secondaryActivityLabel);
            this.Controls.Add(this.secondaryActivityTextBox);
            this.Controls.Add(primaryActivityLabel);
            this.Controls.Add(this.primaryActivityTextBox);
            this.Controls.Add(initialDateLabel);
            this.Controls.Add(this.initialDateDateTimePicker);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(addDateLabel);
            this.Controls.Add(this.addDateDateTimePicker);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(modifiedDateLabel);
            this.Controls.Add(this.modifiedDateDateTimePicker);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.customerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker addDateDateTimePicker;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker modifiedDateDateTimePicker;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker initialDateDateTimePicker;
        private System.Windows.Forms.TextBox primaryActivityTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox secondaryActivityTextBox;
        private System.Windows.Forms.TextBox secondaryDestinationTextBox;
        private System.Windows.Forms.TextBox primaryDestinationTextBox;
    }
}

