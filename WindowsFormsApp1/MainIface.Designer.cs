
namespace WindowsFormsApp1
{
    partial class MainIface
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainIface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnAddMarker = new System.Windows.Forms.Button();
            this.btnClearMarker = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Positions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tbTarget);
            this.flowLayoutPanel1.Controls.Add(this.tbMessage);
            this.flowLayoutPanel1.Controls.Add(this.btnAddMarker);
            this.flowLayoutPanel1.Controls.Add(this.btnClearMarker);
            this.flowLayoutPanel1.Controls.Add(this.btnSend);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(591, 175);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target:";
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(50, 3);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(538, 20);
            this.tbTarget.TabIndex = 1;
            this.tbTarget.Text = "wss://ws.postman-echo.com/raw";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(3, 29);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(585, 87);
            this.tbMessage.TabIndex = 2;
            // 
            // btnAddMarker
            // 
            this.btnAddMarker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMarker.ImageIndex = 3;
            this.btnAddMarker.ImageList = this.imageList1;
            this.btnAddMarker.Location = new System.Drawing.Point(3, 122);
            this.btnAddMarker.Name = "btnAddMarker";
            this.btnAddMarker.Size = new System.Drawing.Size(75, 23);
            this.btnAddMarker.TabIndex = 3;
            this.btnAddMarker.Text = "&Add ";
            this.btnAddMarker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMarker.UseVisualStyleBackColor = true;
            this.btnAddMarker.Click += new System.EventHandler(this.btnAddMarker_Click);
            // 
            // btnClearMarker
            // 
            this.btnClearMarker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearMarker.ImageIndex = 32;
            this.btnClearMarker.ImageList = this.imageList1;
            this.btnClearMarker.Location = new System.Drawing.Point(84, 122);
            this.btnClearMarker.Name = "btnClearMarker";
            this.btnClearMarker.Size = new System.Drawing.Size(75, 23);
            this.btnClearMarker.TabIndex = 4;
            this.btnClearMarker.Text = "&Clear";
            this.btnClearMarker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearMarker.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.ImageIndex = 9;
            this.btnSend.ImageList = this.imageList1;
            this.btnSend.Location = new System.Drawing.Point(165, 122);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "&Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payloads";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(597, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow_down_blue.png");
            this.imageList1.Images.SetKeyName(1, "about.png");
            this.imageList1.Images.SetKeyName(2, "add.png");
            this.imageList1.Images.SetKeyName(3, "add2.png");
            this.imageList1.Images.SetKeyName(4, "arrow_down_blue.png");
            this.imageList1.Images.SetKeyName(5, "arrow_down_green.png");
            this.imageList1.Images.SetKeyName(6, "arrow_left_blue.png");
            this.imageList1.Images.SetKeyName(7, "arrow_left_green.png");
            this.imageList1.Images.SetKeyName(8, "arrow_right_blue.png");
            this.imageList1.Images.SetKeyName(9, "arrow_right_green.png");
            this.imageList1.Images.SetKeyName(10, "arrow_up_blue.png");
            this.imageList1.Images.SetKeyName(11, "arrow_up_green.png");
            this.imageList1.Images.SetKeyName(12, "bookmark.png");
            this.imageList1.Images.SetKeyName(13, "bookmark_add.png");
            this.imageList1.Images.SetKeyName(14, "bookmark_delete.png");
            this.imageList1.Images.SetKeyName(15, "bookmark_down.png");
            this.imageList1.Images.SetKeyName(16, "bookmark_new.png");
            this.imageList1.Images.SetKeyName(17, "bookmark_preferences.png");
            this.imageList1.Images.SetKeyName(18, "bookmark_up.png");
            this.imageList1.Images.SetKeyName(19, "bookmarks.png");
            this.imageList1.Images.SetKeyName(20, "bookmarks_preferences.png");
            this.imageList1.Images.SetKeyName(21, "check.png");
            this.imageList1.Images.SetKeyName(22, "check2.png");
            this.imageList1.Images.SetKeyName(23, "checks.png");
            this.imageList1.Images.SetKeyName(24, "clipboard.png");
            this.imageList1.Images.SetKeyName(25, "clipboard_empty.png");
            this.imageList1.Images.SetKeyName(26, "clipboard_next.png");
            this.imageList1.Images.SetKeyName(27, "clipboard_next_down.png");
            this.imageList1.Images.SetKeyName(28, "contract.png");
            this.imageList1.Images.SetKeyName(29, "copy.png");
            this.imageList1.Images.SetKeyName(30, "cut.png");
            this.imageList1.Images.SetKeyName(31, "delete.png");
            this.imageList1.Images.SetKeyName(32, "delete2.png");
            this.imageList1.Images.SetKeyName(33, "desktop.png");
            this.imageList1.Images.SetKeyName(34, "disk_blue.png");
            this.imageList1.Images.SetKeyName(35, "disk_blue_error.png");
            this.imageList1.Images.SetKeyName(36, "disk_blue_information.png");
            this.imageList1.Images.SetKeyName(37, "disk_blue_ok.png");
            this.imageList1.Images.SetKeyName(38, "disk_blue_warning.png");
            this.imageList1.Images.SetKeyName(39, "disk_blue_window.png");
            this.imageList1.Images.SetKeyName(40, "disk_green.png");
            this.imageList1.Images.SetKeyName(41, "disk_yellow.png");
            this.imageList1.Images.SetKeyName(42, "diskdrive.png");
            this.imageList1.Images.SetKeyName(43, "disks.png");
            this.imageList1.Images.SetKeyName(44, "document.png");
            this.imageList1.Images.SetKeyName(45, "document_add.png");
            this.imageList1.Images.SetKeyName(46, "document_attachment.png");
            this.imageList1.Images.SetKeyName(47, "document_certificate.png");
            this.imageList1.Images.SetKeyName(48, "document_chart.png");
            this.imageList1.Images.SetKeyName(49, "document_check.png");
            this.imageList1.Images.SetKeyName(50, "document_connection.png");
            this.imageList1.Images.SetKeyName(51, "document_cup.png");
            this.imageList1.Images.SetKeyName(52, "document_delete.png");
            this.imageList1.Images.SetKeyName(53, "document_dirty.png");
            this.imageList1.Images.SetKeyName(54, "document_edit.png");
            this.imageList1.Images.SetKeyName(55, "document_error.png");
            this.imageList1.Images.SetKeyName(56, "document_exchange.png");
            this.imageList1.Images.SetKeyName(57, "document_find.png");
            this.imageList1.Images.SetKeyName(58, "document_gear.png");
            this.imageList1.Images.SetKeyName(59, "document_heart.png");
            this.imageList1.Images.SetKeyName(60, "document_info.png");
            this.imageList1.Images.SetKeyName(61, "document_into.png");
            this.imageList1.Images.SetKeyName(62, "document_lock.png");
            this.imageList1.Images.SetKeyName(63, "document_music.png");
            this.imageList1.Images.SetKeyName(64, "document_new.png");
            this.imageList1.Images.SetKeyName(65, "document_notebook.png");
            this.imageList1.Images.SetKeyName(66, "document_ok.png");
            this.imageList1.Images.SetKeyName(67, "document_out.png");
            this.imageList1.Images.SetKeyName(68, "document_pinned.png");
            this.imageList1.Images.SetKeyName(69, "document_plain.png");
            this.imageList1.Images.SetKeyName(70, "document_plain_new.png");
            this.imageList1.Images.SetKeyName(71, "document_preferences.png");
            this.imageList1.Images.SetKeyName(72, "document_pulse.png");
            this.imageList1.Images.SetKeyName(73, "document_refresh.png");
            this.imageList1.Images.SetKeyName(74, "document_stop.png");
            this.imageList1.Images.SetKeyName(75, "document_text.png");
            this.imageList1.Images.SetKeyName(76, "document_time.png");
            this.imageList1.Images.SetKeyName(77, "document_view.png");
            this.imageList1.Images.SetKeyName(78, "document_warning.png");
            this.imageList1.Images.SetKeyName(79, "document_zoom_in.png");
            this.imageList1.Images.SetKeyName(80, "document_zoom_out.png");
            this.imageList1.Images.SetKeyName(81, "documents.png");
            this.imageList1.Images.SetKeyName(82, "documents_gear.png");
            this.imageList1.Images.SetKeyName(83, "documents_new.png");
            this.imageList1.Images.SetKeyName(84, "documents_preferences.png");
            this.imageList1.Images.SetKeyName(85, "edit.png");
            this.imageList1.Images.SetKeyName(86, "error.png");
            this.imageList1.Images.SetKeyName(87, "exchange.png");
            this.imageList1.Images.SetKeyName(88, "export1.png");
            this.imageList1.Images.SetKeyName(89, "export2.png");
            this.imageList1.Images.SetKeyName(90, "find.png");
            this.imageList1.Images.SetKeyName(91, "find_again.png");
            this.imageList1.Images.SetKeyName(92, "find_next.png");
            this.imageList1.Images.SetKeyName(93, "find_previous.png");
            this.imageList1.Images.SetKeyName(94, "find_selection.png");
            this.imageList1.Images.SetKeyName(95, "find_text.png");
            this.imageList1.Images.SetKeyName(96, "first_aid.png");
            this.imageList1.Images.SetKeyName(97, "first_aid_box.png");
            this.imageList1.Images.SetKeyName(98, "flash.png");
            this.imageList1.Images.SetKeyName(99, "folder.png");
            this.imageList1.Images.SetKeyName(100, "folder_add.png");
            this.imageList1.Images.SetKeyName(101, "folder_closed.png");
            this.imageList1.Images.SetKeyName(102, "folder_cubes.png");
            this.imageList1.Images.SetKeyName(103, "folder_delete.png");
            this.imageList1.Images.SetKeyName(104, "folder_document.png");
            this.imageList1.Images.SetKeyName(105, "folder_edit.png");
            this.imageList1.Images.SetKeyName(106, "folder_forbidden.png");
            this.imageList1.Images.SetKeyName(107, "folder_gear.png");
            this.imageList1.Images.SetKeyName(108, "folder_information.png");
            this.imageList1.Images.SetKeyName(109, "folder_into.png");
            this.imageList1.Images.SetKeyName(110, "folder_lock.png");
            this.imageList1.Images.SetKeyName(111, "folder_movie.png");
            this.imageList1.Images.SetKeyName(112, "folder_music.png");
            this.imageList1.Images.SetKeyName(113, "folder_network.png");
            this.imageList1.Images.SetKeyName(114, "folder_new.png");
            this.imageList1.Images.SetKeyName(115, "folder_ok.png");
            this.imageList1.Images.SetKeyName(116, "folder_out.png");
            this.imageList1.Images.SetKeyName(117, "folder_preferences.png");
            this.imageList1.Images.SetKeyName(118, "folder_refresh.png");
            this.imageList1.Images.SetKeyName(119, "folder_time.png");
            this.imageList1.Images.SetKeyName(120, "folder_up.png");
            this.imageList1.Images.SetKeyName(121, "folder_view.png");
            this.imageList1.Images.SetKeyName(122, "folder_warning.png");
            this.imageList1.Images.SetKeyName(123, "folder_window.png");
            this.imageList1.Images.SetKeyName(124, "folders.png");
            this.imageList1.Images.SetKeyName(125, "font.png");
            this.imageList1.Images.SetKeyName(126, "forbidden.png");
            this.imageList1.Images.SetKeyName(127, "form_blue.png");
            this.imageList1.Images.SetKeyName(128, "form_green.png");
            this.imageList1.Images.SetKeyName(129, "form_red.png");
            this.imageList1.Images.SetKeyName(130, "form_yellow.png");
            this.imageList1.Images.SetKeyName(131, "garbage.png");
            this.imageList1.Images.SetKeyName(132, "garbage_empty.png");
            this.imageList1.Images.SetKeyName(133, "garbage_full.png");
            this.imageList1.Images.SetKeyName(134, "gear.png");
            this.imageList1.Images.SetKeyName(135, "gear_add.png");
            this.imageList1.Images.SetKeyName(136, "gear_connection.png");
            this.imageList1.Images.SetKeyName(137, "gear_delete.png");
            this.imageList1.Images.SetKeyName(138, "gear_error.png");
            this.imageList1.Images.SetKeyName(139, "gear_find.png");
            this.imageList1.Images.SetKeyName(140, "gear_forbidden.png");
            this.imageList1.Images.SetKeyName(141, "gear_information.png");
            this.imageList1.Images.SetKeyName(142, "gear_new.png");
            this.imageList1.Images.SetKeyName(143, "gear_ok.png");
            this.imageList1.Images.SetKeyName(144, "gear_pause.png");
            this.imageList1.Images.SetKeyName(145, "gear_preferences.png");
            this.imageList1.Images.SetKeyName(146, "gear_refresh.png");
            this.imageList1.Images.SetKeyName(147, "gear_replace.png");
            this.imageList1.Images.SetKeyName(148, "gear_run.png");
            this.imageList1.Images.SetKeyName(149, "gear_stop.png");
            this.imageList1.Images.SetKeyName(150, "gear_time.png");
            this.imageList1.Images.SetKeyName(151, "gear_view.png");
            this.imageList1.Images.SetKeyName(152, "gear_warning.png");
            this.imageList1.Images.SetKeyName(153, "gears.png");
            this.imageList1.Images.SetKeyName(154, "gears_pause.png");
            this.imageList1.Images.SetKeyName(155, "gears_preferences.png");
            this.imageList1.Images.SetKeyName(156, "gears_run.png");
            this.imageList1.Images.SetKeyName(157, "gears_stop.png");
            this.imageList1.Images.SetKeyName(158, "gears_view.png");
            this.imageList1.Images.SetKeyName(159, "harddisk.png");
            this.imageList1.Images.SetKeyName(160, "harddisk_add.png");
            this.imageList1.Images.SetKeyName(161, "harddisk_delete.png");
            this.imageList1.Images.SetKeyName(162, "harddisk_network.png");
            this.imageList1.Images.SetKeyName(163, "heart.png");
            this.imageList1.Images.SetKeyName(164, "heart_add.png");
            this.imageList1.Images.SetKeyName(165, "heart_broken.png");
            this.imageList1.Images.SetKeyName(166, "heart_delete.png");
            this.imageList1.Images.SetKeyName(167, "heart_new.png");
            this.imageList1.Images.SetKeyName(168, "heart_preferences.png");
            this.imageList1.Images.SetKeyName(169, "help.png");
            this.imageList1.Images.SetKeyName(170, "help_earth.png");
            this.imageList1.Images.SetKeyName(171, "help2.png");
            this.imageList1.Images.SetKeyName(172, "history.png");
            this.imageList1.Images.SetKeyName(173, "history_add.png");
            this.imageList1.Images.SetKeyName(174, "history_delete.png");
            this.imageList1.Images.SetKeyName(175, "history2.png");
            this.imageList1.Images.SetKeyName(176, "import1.png");
            this.imageList1.Images.SetKeyName(177, "import2.png");
            this.imageList1.Images.SetKeyName(178, "information.png");
            this.imageList1.Images.SetKeyName(179, "lifebelt.png");
            this.imageList1.Images.SetKeyName(180, "lightbulb.png");
            this.imageList1.Images.SetKeyName(181, "lightbulb_on.png");
            this.imageList1.Images.SetKeyName(182, "magic-wand.png");
            this.imageList1.Images.SetKeyName(183, "magic-wand2.png");
            this.imageList1.Images.SetKeyName(184, "media_beginning.png");
            this.imageList1.Images.SetKeyName(185, "media_end.png");
            this.imageList1.Images.SetKeyName(186, "media_fast_forward.png");
            this.imageList1.Images.SetKeyName(187, "media_pause.png");
            this.imageList1.Images.SetKeyName(188, "media_play.png");
            this.imageList1.Images.SetKeyName(189, "media_play_green.png");
            this.imageList1.Images.SetKeyName(190, "media_rewind.png");
            this.imageList1.Images.SetKeyName(191, "media_step_back.png");
            this.imageList1.Images.SetKeyName(192, "media_step_forward.png");
            this.imageList1.Images.SetKeyName(193, "media_stop.png");
            this.imageList1.Images.SetKeyName(194, "media_stop_red.png");
            this.imageList1.Images.SetKeyName(195, "music.png");
            this.imageList1.Images.SetKeyName(196, "nav_down_blue.png");
            this.imageList1.Images.SetKeyName(197, "nav_down_green.png");
            this.imageList1.Images.SetKeyName(198, "nav_down_left_blue.png");
            this.imageList1.Images.SetKeyName(199, "nav_down_left_green.png");
            this.imageList1.Images.SetKeyName(200, "nav_down_left_red.png");
            this.imageList1.Images.SetKeyName(201, "nav_down_red.png");
            this.imageList1.Images.SetKeyName(202, "nav_down_right_blue.png");
            this.imageList1.Images.SetKeyName(203, "nav_down_right_green.png");
            this.imageList1.Images.SetKeyName(204, "nav_down_right_red.png");
            this.imageList1.Images.SetKeyName(205, "nav_left_blue.png");
            this.imageList1.Images.SetKeyName(206, "nav_left_green.png");
            this.imageList1.Images.SetKeyName(207, "nav_left_red.png");
            this.imageList1.Images.SetKeyName(208, "nav_right_blue.png");
            this.imageList1.Images.SetKeyName(209, "nav_right_green.png");
            this.imageList1.Images.SetKeyName(210, "nav_right_red.png");
            this.imageList1.Images.SetKeyName(211, "nav_up_blue.png");
            this.imageList1.Images.SetKeyName(212, "nav_up_green.png");
            this.imageList1.Images.SetKeyName(213, "nav_up_left_blue.png");
            this.imageList1.Images.SetKeyName(214, "nav_up_left_green.png");
            this.imageList1.Images.SetKeyName(215, "nav_up_left_red.png");
            this.imageList1.Images.SetKeyName(216, "nav_up_red.png");
            this.imageList1.Images.SetKeyName(217, "nav_up_right_blue.png");
            this.imageList1.Images.SetKeyName(218, "nav_up_right_green.png");
            this.imageList1.Images.SetKeyName(219, "nav_up_right_red.png");
            this.imageList1.Images.SetKeyName(220, "navigate_down.png");
            this.imageList1.Images.SetKeyName(221, "navigate_down2.png");
            this.imageList1.Images.SetKeyName(222, "navigate_left.png");
            this.imageList1.Images.SetKeyName(223, "navigate_left2.png");
            this.imageList1.Images.SetKeyName(224, "navigate_right.png");
            this.imageList1.Images.SetKeyName(225, "navigate_right2.png");
            this.imageList1.Images.SetKeyName(226, "navigate_up.png");
            this.imageList1.Images.SetKeyName(227, "navigate_up2.png");
            this.imageList1.Images.SetKeyName(228, "notebook.png");
            this.imageList1.Images.SetKeyName(229, "notebook_preferences.png");
            this.imageList1.Images.SetKeyName(230, "paste.png");
            this.imageList1.Images.SetKeyName(231, "photo_portrait.png");
            this.imageList1.Images.SetKeyName(232, "photo_scenery.png");
            this.imageList1.Images.SetKeyName(233, "preferences.png");
            this.imageList1.Images.SetKeyName(234, "question_and_answer.png");
            this.imageList1.Images.SetKeyName(235, "recycle.png");
            this.imageList1.Images.SetKeyName(236, "recycle_preferences.png");
            this.imageList1.Images.SetKeyName(237, "redo.png");
            this.imageList1.Images.SetKeyName(238, "refresh.png");
            this.imageList1.Images.SetKeyName(239, "replace.png");
            this.imageList1.Images.SetKeyName(240, "replace2.png");
            this.imageList1.Images.SetKeyName(241, "save_as.png");
            this.imageList1.Images.SetKeyName(242, "scroll.png");
            this.imageList1.Images.SetKeyName(243, "scroll_add.png");
            this.imageList1.Images.SetKeyName(244, "scroll_delete.png");
            this.imageList1.Images.SetKeyName(245, "scroll_error.png");
            this.imageList1.Images.SetKeyName(246, "scroll_information.png");
            this.imageList1.Images.SetKeyName(247, "scroll_ok.png");
            this.imageList1.Images.SetKeyName(248, "scroll_preferences.png");
            this.imageList1.Images.SetKeyName(249, "scroll_refresh.png");
            this.imageList1.Images.SetKeyName(250, "scroll_replace.png");
            this.imageList1.Images.SetKeyName(251, "scroll_run.png");
            this.imageList1.Images.SetKeyName(252, "scroll_stop.png");
            this.imageList1.Images.SetKeyName(253, "scroll_view.png");
            this.imageList1.Images.SetKeyName(254, "scroll_warning.png");
            this.imageList1.Images.SetKeyName(255, "selection.png");
            this.imageList1.Images.SetKeyName(256, "selection_delete.png");
            this.imageList1.Images.SetKeyName(257, "selection_recycle.png");
            this.imageList1.Images.SetKeyName(258, "selection_replace.png");
            this.imageList1.Images.SetKeyName(259, "signpost.png");
            this.imageList1.Images.SetKeyName(260, "star_blue.png");
            this.imageList1.Images.SetKeyName(261, "star_green.png");
            this.imageList1.Images.SetKeyName(262, "star_grey.png");
            this.imageList1.Images.SetKeyName(263, "star_red.png");
            this.imageList1.Images.SetKeyName(264, "star_yellow.png");
            this.imageList1.Images.SetKeyName(265, "star_yellow_add.png");
            this.imageList1.Images.SetKeyName(266, "star_yellow_delete.png");
            this.imageList1.Images.SetKeyName(267, "star_yellow_new.png");
            this.imageList1.Images.SetKeyName(268, "star_yellow_preferences.png");
            this.imageList1.Images.SetKeyName(269, "star_yellow_view.png");
            this.imageList1.Images.SetKeyName(270, "stop.png");
            this.imageList1.Images.SetKeyName(271, "text.png");
            this.imageList1.Images.SetKeyName(272, "text_align_center.png");
            this.imageList1.Images.SetKeyName(273, "text_align_justified.png");
            this.imageList1.Images.SetKeyName(274, "text_align_left.png");
            this.imageList1.Images.SetKeyName(275, "text_align_right.png");
            this.imageList1.Images.SetKeyName(276, "text_binary.png");
            this.imageList1.Images.SetKeyName(277, "text_bold.png");
            this.imageList1.Images.SetKeyName(278, "text_braille.png");
            this.imageList1.Images.SetKeyName(279, "text_find.png");
            this.imageList1.Images.SetKeyName(280, "text_italics.png");
            this.imageList1.Images.SetKeyName(281, "text_lock.png");
            this.imageList1.Images.SetKeyName(282, "text_loudspeaker.png");
            this.imageList1.Images.SetKeyName(283, "text_marked.png");
            this.imageList1.Images.SetKeyName(284, "text_normal.png");
            this.imageList1.Images.SetKeyName(285, "text_ok.png");
            this.imageList1.Images.SetKeyName(286, "text_rich.png");
            this.imageList1.Images.SetKeyName(287, "text_rich_colored.png");
            this.imageList1.Images.SetKeyName(288, "text_rich_marked.png");
            this.imageList1.Images.SetKeyName(289, "text_tree.png");
            this.imageList1.Images.SetKeyName(290, "text_underlined.png");
            this.imageList1.Images.SetKeyName(291, "text_view.png");
            this.imageList1.Images.SetKeyName(292, "transform.png");
            this.imageList1.Images.SetKeyName(293, "transform2.png");
            this.imageList1.Images.SetKeyName(294, "undo.png");
            this.imageList1.Images.SetKeyName(295, "unknown.png");
            this.imageList1.Images.SetKeyName(296, "view.png");
            this.imageList1.Images.SetKeyName(297, "view_next.png");
            this.imageList1.Images.SetKeyName(298, "view_previous.png");
            this.imageList1.Images.SetKeyName(299, "warning.png");
            this.imageList1.Images.SetKeyName(300, "window.png");
            this.imageList1.Images.SetKeyName(301, "window_add.png");
            this.imageList1.Images.SetKeyName(302, "window_colors.png");
            this.imageList1.Images.SetKeyName(303, "window_delete.png");
            this.imageList1.Images.SetKeyName(304, "window_earth.png");
            this.imageList1.Images.SetKeyName(305, "window_edit.png");
            this.imageList1.Images.SetKeyName(306, "window_environment.png");
            this.imageList1.Images.SetKeyName(307, "window_gear.png");
            this.imageList1.Images.SetKeyName(308, "window_information.png");
            this.imageList1.Images.SetKeyName(309, "window_new.png");
            this.imageList1.Images.SetKeyName(310, "window_preferences.png");
            this.imageList1.Images.SetKeyName(311, "window_sidebar.png");
            this.imageList1.Images.SetKeyName(312, "window_split_hor.png");
            this.imageList1.Images.SetKeyName(313, "window_split_ver.png");
            this.imageList1.Images.SetKeyName(314, "window_star.png");
            this.imageList1.Images.SetKeyName(315, "window_time.png");
            this.imageList1.Images.SetKeyName(316, "window_view.png");
            this.imageList1.Images.SetKeyName(317, "window_warning.png");
            this.imageList1.Images.SetKeyName(318, "windows.png");
            this.imageList1.Images.SetKeyName(319, "zoom_in.png");
            this.imageList1.Images.SetKeyName(320, "zoom_out.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(591, 396);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(591, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainIface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "MainIface";
            this.Size = new System.Drawing.Size(605, 428);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnAddMarker;
        private System.Windows.Forms.Button btnClearMarker;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
