﻿
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainIface1 = new WindowsFormsApp1.MainIface();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 401);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mainIface1);
            this.tabPage1.ImageIndex = 306;
            this.tabPage1.Location = new System.Drawing.Point(4, 55);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainIface1
            // 
            this.mainIface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainIface1.Location = new System.Drawing.Point(3, 3);
            this.mainIface1.Name = "mainIface1";
            this.mainIface1.Size = new System.Drawing.Size(786, 336);
            this.mainIface1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 55);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "add2.png");
            this.imageList1.Images.SetKeyName(3, "arrow_down_blue.png");
            this.imageList1.Images.SetKeyName(4, "arrow_down_green.png");
            this.imageList1.Images.SetKeyName(5, "arrow_left_blue.png");
            this.imageList1.Images.SetKeyName(6, "arrow_left_green.png");
            this.imageList1.Images.SetKeyName(7, "arrow_right_blue.png");
            this.imageList1.Images.SetKeyName(8, "arrow_right_green.png");
            this.imageList1.Images.SetKeyName(9, "arrow_up_blue.png");
            this.imageList1.Images.SetKeyName(10, "arrow_up_green.png");
            this.imageList1.Images.SetKeyName(11, "bookmark.png");
            this.imageList1.Images.SetKeyName(12, "bookmark_add.png");
            this.imageList1.Images.SetKeyName(13, "bookmark_delete.png");
            this.imageList1.Images.SetKeyName(14, "bookmark_down.png");
            this.imageList1.Images.SetKeyName(15, "bookmark_new.png");
            this.imageList1.Images.SetKeyName(16, "bookmark_preferences.png");
            this.imageList1.Images.SetKeyName(17, "bookmark_up.png");
            this.imageList1.Images.SetKeyName(18, "bookmarks.png");
            this.imageList1.Images.SetKeyName(19, "bookmarks_preferences.png");
            this.imageList1.Images.SetKeyName(20, "check.png");
            this.imageList1.Images.SetKeyName(21, "check2.png");
            this.imageList1.Images.SetKeyName(22, "checks.png");
            this.imageList1.Images.SetKeyName(23, "clipboard.png");
            this.imageList1.Images.SetKeyName(24, "clipboard_empty.png");
            this.imageList1.Images.SetKeyName(25, "clipboard_next.png");
            this.imageList1.Images.SetKeyName(26, "clipboard_next_down.png");
            this.imageList1.Images.SetKeyName(27, "contract.png");
            this.imageList1.Images.SetKeyName(28, "copy.png");
            this.imageList1.Images.SetKeyName(29, "cut.png");
            this.imageList1.Images.SetKeyName(30, "delete.png");
            this.imageList1.Images.SetKeyName(31, "delete2.png");
            this.imageList1.Images.SetKeyName(32, "desktop.png");
            this.imageList1.Images.SetKeyName(33, "disk_blue.png");
            this.imageList1.Images.SetKeyName(34, "disk_blue_error.png");
            this.imageList1.Images.SetKeyName(35, "disk_blue_information.png");
            this.imageList1.Images.SetKeyName(36, "disk_blue_ok.png");
            this.imageList1.Images.SetKeyName(37, "disk_blue_warning.png");
            this.imageList1.Images.SetKeyName(38, "disk_blue_window.png");
            this.imageList1.Images.SetKeyName(39, "disk_green.png");
            this.imageList1.Images.SetKeyName(40, "disk_yellow.png");
            this.imageList1.Images.SetKeyName(41, "diskdrive.png");
            this.imageList1.Images.SetKeyName(42, "disks.png");
            this.imageList1.Images.SetKeyName(43, "document.png");
            this.imageList1.Images.SetKeyName(44, "document_add.png");
            this.imageList1.Images.SetKeyName(45, "document_attachment.png");
            this.imageList1.Images.SetKeyName(46, "document_certificate.png");
            this.imageList1.Images.SetKeyName(47, "document_chart.png");
            this.imageList1.Images.SetKeyName(48, "document_check.png");
            this.imageList1.Images.SetKeyName(49, "document_connection.png");
            this.imageList1.Images.SetKeyName(50, "document_cup.png");
            this.imageList1.Images.SetKeyName(51, "document_delete.png");
            this.imageList1.Images.SetKeyName(52, "document_dirty.png");
            this.imageList1.Images.SetKeyName(53, "document_edit.png");
            this.imageList1.Images.SetKeyName(54, "document_error.png");
            this.imageList1.Images.SetKeyName(55, "document_exchange.png");
            this.imageList1.Images.SetKeyName(56, "document_find.png");
            this.imageList1.Images.SetKeyName(57, "document_gear.png");
            this.imageList1.Images.SetKeyName(58, "document_heart.png");
            this.imageList1.Images.SetKeyName(59, "document_info.png");
            this.imageList1.Images.SetKeyName(60, "document_into.png");
            this.imageList1.Images.SetKeyName(61, "document_lock.png");
            this.imageList1.Images.SetKeyName(62, "document_music.png");
            this.imageList1.Images.SetKeyName(63, "document_new.png");
            this.imageList1.Images.SetKeyName(64, "document_notebook.png");
            this.imageList1.Images.SetKeyName(65, "document_ok.png");
            this.imageList1.Images.SetKeyName(66, "document_out.png");
            this.imageList1.Images.SetKeyName(67, "document_pinned.png");
            this.imageList1.Images.SetKeyName(68, "document_plain.png");
            this.imageList1.Images.SetKeyName(69, "document_plain_new.png");
            this.imageList1.Images.SetKeyName(70, "document_preferences.png");
            this.imageList1.Images.SetKeyName(71, "document_pulse.png");
            this.imageList1.Images.SetKeyName(72, "document_refresh.png");
            this.imageList1.Images.SetKeyName(73, "document_stop.png");
            this.imageList1.Images.SetKeyName(74, "document_text.png");
            this.imageList1.Images.SetKeyName(75, "document_time.png");
            this.imageList1.Images.SetKeyName(76, "document_view.png");
            this.imageList1.Images.SetKeyName(77, "document_warning.png");
            this.imageList1.Images.SetKeyName(78, "document_zoom_in.png");
            this.imageList1.Images.SetKeyName(79, "document_zoom_out.png");
            this.imageList1.Images.SetKeyName(80, "documents.png");
            this.imageList1.Images.SetKeyName(81, "documents_gear.png");
            this.imageList1.Images.SetKeyName(82, "documents_new.png");
            this.imageList1.Images.SetKeyName(83, "documents_preferences.png");
            this.imageList1.Images.SetKeyName(84, "edit.png");
            this.imageList1.Images.SetKeyName(85, "error.png");
            this.imageList1.Images.SetKeyName(86, "exchange.png");
            this.imageList1.Images.SetKeyName(87, "export1.png");
            this.imageList1.Images.SetKeyName(88, "export2.png");
            this.imageList1.Images.SetKeyName(89, "find.png");
            this.imageList1.Images.SetKeyName(90, "find_again.png");
            this.imageList1.Images.SetKeyName(91, "find_next.png");
            this.imageList1.Images.SetKeyName(92, "find_previous.png");
            this.imageList1.Images.SetKeyName(93, "find_selection.png");
            this.imageList1.Images.SetKeyName(94, "find_text.png");
            this.imageList1.Images.SetKeyName(95, "first_aid.png");
            this.imageList1.Images.SetKeyName(96, "first_aid_box.png");
            this.imageList1.Images.SetKeyName(97, "flash.png");
            this.imageList1.Images.SetKeyName(98, "folder.png");
            this.imageList1.Images.SetKeyName(99, "folder_add.png");
            this.imageList1.Images.SetKeyName(100, "folder_closed.png");
            this.imageList1.Images.SetKeyName(101, "folder_cubes.png");
            this.imageList1.Images.SetKeyName(102, "folder_delete.png");
            this.imageList1.Images.SetKeyName(103, "folder_document.png");
            this.imageList1.Images.SetKeyName(104, "folder_edit.png");
            this.imageList1.Images.SetKeyName(105, "folder_forbidden.png");
            this.imageList1.Images.SetKeyName(106, "folder_gear.png");
            this.imageList1.Images.SetKeyName(107, "folder_information.png");
            this.imageList1.Images.SetKeyName(108, "folder_into.png");
            this.imageList1.Images.SetKeyName(109, "folder_lock.png");
            this.imageList1.Images.SetKeyName(110, "folder_movie.png");
            this.imageList1.Images.SetKeyName(111, "folder_music.png");
            this.imageList1.Images.SetKeyName(112, "folder_network.png");
            this.imageList1.Images.SetKeyName(113, "folder_new.png");
            this.imageList1.Images.SetKeyName(114, "folder_ok.png");
            this.imageList1.Images.SetKeyName(115, "folder_out.png");
            this.imageList1.Images.SetKeyName(116, "folder_preferences.png");
            this.imageList1.Images.SetKeyName(117, "folder_refresh.png");
            this.imageList1.Images.SetKeyName(118, "folder_time.png");
            this.imageList1.Images.SetKeyName(119, "folder_up.png");
            this.imageList1.Images.SetKeyName(120, "folder_view.png");
            this.imageList1.Images.SetKeyName(121, "folder_warning.png");
            this.imageList1.Images.SetKeyName(122, "folder_window.png");
            this.imageList1.Images.SetKeyName(123, "folders.png");
            this.imageList1.Images.SetKeyName(124, "font.png");
            this.imageList1.Images.SetKeyName(125, "forbidden.png");
            this.imageList1.Images.SetKeyName(126, "form_blue.png");
            this.imageList1.Images.SetKeyName(127, "form_green.png");
            this.imageList1.Images.SetKeyName(128, "form_red.png");
            this.imageList1.Images.SetKeyName(129, "form_yellow.png");
            this.imageList1.Images.SetKeyName(130, "garbage.png");
            this.imageList1.Images.SetKeyName(131, "garbage_empty.png");
            this.imageList1.Images.SetKeyName(132, "garbage_full.png");
            this.imageList1.Images.SetKeyName(133, "gear.png");
            this.imageList1.Images.SetKeyName(134, "gear_add.png");
            this.imageList1.Images.SetKeyName(135, "gear_connection.png");
            this.imageList1.Images.SetKeyName(136, "gear_delete.png");
            this.imageList1.Images.SetKeyName(137, "gear_error.png");
            this.imageList1.Images.SetKeyName(138, "gear_find.png");
            this.imageList1.Images.SetKeyName(139, "gear_forbidden.png");
            this.imageList1.Images.SetKeyName(140, "gear_information.png");
            this.imageList1.Images.SetKeyName(141, "gear_new.png");
            this.imageList1.Images.SetKeyName(142, "gear_ok.png");
            this.imageList1.Images.SetKeyName(143, "gear_pause.png");
            this.imageList1.Images.SetKeyName(144, "gear_preferences.png");
            this.imageList1.Images.SetKeyName(145, "gear_refresh.png");
            this.imageList1.Images.SetKeyName(146, "gear_replace.png");
            this.imageList1.Images.SetKeyName(147, "gear_run.png");
            this.imageList1.Images.SetKeyName(148, "gear_stop.png");
            this.imageList1.Images.SetKeyName(149, "gear_time.png");
            this.imageList1.Images.SetKeyName(150, "gear_view.png");
            this.imageList1.Images.SetKeyName(151, "gear_warning.png");
            this.imageList1.Images.SetKeyName(152, "gears.png");
            this.imageList1.Images.SetKeyName(153, "gears_pause.png");
            this.imageList1.Images.SetKeyName(154, "gears_preferences.png");
            this.imageList1.Images.SetKeyName(155, "gears_run.png");
            this.imageList1.Images.SetKeyName(156, "gears_stop.png");
            this.imageList1.Images.SetKeyName(157, "gears_view.png");
            this.imageList1.Images.SetKeyName(158, "harddisk.png");
            this.imageList1.Images.SetKeyName(159, "harddisk_add.png");
            this.imageList1.Images.SetKeyName(160, "harddisk_delete.png");
            this.imageList1.Images.SetKeyName(161, "harddisk_network.png");
            this.imageList1.Images.SetKeyName(162, "heart.png");
            this.imageList1.Images.SetKeyName(163, "heart_add.png");
            this.imageList1.Images.SetKeyName(164, "heart_broken.png");
            this.imageList1.Images.SetKeyName(165, "heart_delete.png");
            this.imageList1.Images.SetKeyName(166, "heart_new.png");
            this.imageList1.Images.SetKeyName(167, "heart_preferences.png");
            this.imageList1.Images.SetKeyName(168, "help.png");
            this.imageList1.Images.SetKeyName(169, "help_earth.png");
            this.imageList1.Images.SetKeyName(170, "help2.png");
            this.imageList1.Images.SetKeyName(171, "history.png");
            this.imageList1.Images.SetKeyName(172, "history_add.png");
            this.imageList1.Images.SetKeyName(173, "history_delete.png");
            this.imageList1.Images.SetKeyName(174, "history2.png");
            this.imageList1.Images.SetKeyName(175, "import1.png");
            this.imageList1.Images.SetKeyName(176, "import2.png");
            this.imageList1.Images.SetKeyName(177, "information.png");
            this.imageList1.Images.SetKeyName(178, "lifebelt.png");
            this.imageList1.Images.SetKeyName(179, "lightbulb.png");
            this.imageList1.Images.SetKeyName(180, "lightbulb_on.png");
            this.imageList1.Images.SetKeyName(181, "magic-wand.png");
            this.imageList1.Images.SetKeyName(182, "magic-wand2.png");
            this.imageList1.Images.SetKeyName(183, "media_beginning.png");
            this.imageList1.Images.SetKeyName(184, "media_end.png");
            this.imageList1.Images.SetKeyName(185, "media_fast_forward.png");
            this.imageList1.Images.SetKeyName(186, "media_pause.png");
            this.imageList1.Images.SetKeyName(187, "media_play.png");
            this.imageList1.Images.SetKeyName(188, "media_play_green.png");
            this.imageList1.Images.SetKeyName(189, "media_rewind.png");
            this.imageList1.Images.SetKeyName(190, "media_step_back.png");
            this.imageList1.Images.SetKeyName(191, "media_step_forward.png");
            this.imageList1.Images.SetKeyName(192, "media_stop.png");
            this.imageList1.Images.SetKeyName(193, "media_stop_red.png");
            this.imageList1.Images.SetKeyName(194, "music.png");
            this.imageList1.Images.SetKeyName(195, "nav_down_blue.png");
            this.imageList1.Images.SetKeyName(196, "nav_down_green.png");
            this.imageList1.Images.SetKeyName(197, "nav_down_left_blue.png");
            this.imageList1.Images.SetKeyName(198, "nav_down_left_green.png");
            this.imageList1.Images.SetKeyName(199, "nav_down_left_red.png");
            this.imageList1.Images.SetKeyName(200, "nav_down_red.png");
            this.imageList1.Images.SetKeyName(201, "nav_down_right_blue.png");
            this.imageList1.Images.SetKeyName(202, "nav_down_right_green.png");
            this.imageList1.Images.SetKeyName(203, "nav_down_right_red.png");
            this.imageList1.Images.SetKeyName(204, "nav_left_blue.png");
            this.imageList1.Images.SetKeyName(205, "nav_left_green.png");
            this.imageList1.Images.SetKeyName(206, "nav_left_red.png");
            this.imageList1.Images.SetKeyName(207, "nav_right_blue.png");
            this.imageList1.Images.SetKeyName(208, "nav_right_green.png");
            this.imageList1.Images.SetKeyName(209, "nav_right_red.png");
            this.imageList1.Images.SetKeyName(210, "nav_up_blue.png");
            this.imageList1.Images.SetKeyName(211, "nav_up_green.png");
            this.imageList1.Images.SetKeyName(212, "nav_up_left_blue.png");
            this.imageList1.Images.SetKeyName(213, "nav_up_left_green.png");
            this.imageList1.Images.SetKeyName(214, "nav_up_left_red.png");
            this.imageList1.Images.SetKeyName(215, "nav_up_red.png");
            this.imageList1.Images.SetKeyName(216, "nav_up_right_blue.png");
            this.imageList1.Images.SetKeyName(217, "nav_up_right_green.png");
            this.imageList1.Images.SetKeyName(218, "nav_up_right_red.png");
            this.imageList1.Images.SetKeyName(219, "navigate_down.png");
            this.imageList1.Images.SetKeyName(220, "navigate_down2.png");
            this.imageList1.Images.SetKeyName(221, "navigate_left.png");
            this.imageList1.Images.SetKeyName(222, "navigate_left2.png");
            this.imageList1.Images.SetKeyName(223, "navigate_right.png");
            this.imageList1.Images.SetKeyName(224, "navigate_right2.png");
            this.imageList1.Images.SetKeyName(225, "navigate_up.png");
            this.imageList1.Images.SetKeyName(226, "navigate_up2.png");
            this.imageList1.Images.SetKeyName(227, "notebook.png");
            this.imageList1.Images.SetKeyName(228, "notebook_preferences.png");
            this.imageList1.Images.SetKeyName(229, "paste.png");
            this.imageList1.Images.SetKeyName(230, "photo_portrait.png");
            this.imageList1.Images.SetKeyName(231, "photo_scenery.png");
            this.imageList1.Images.SetKeyName(232, "preferences.png");
            this.imageList1.Images.SetKeyName(233, "question_and_answer.png");
            this.imageList1.Images.SetKeyName(234, "recycle.png");
            this.imageList1.Images.SetKeyName(235, "recycle_preferences.png");
            this.imageList1.Images.SetKeyName(236, "redo.png");
            this.imageList1.Images.SetKeyName(237, "refresh.png");
            this.imageList1.Images.SetKeyName(238, "replace.png");
            this.imageList1.Images.SetKeyName(239, "replace2.png");
            this.imageList1.Images.SetKeyName(240, "save_as.png");
            this.imageList1.Images.SetKeyName(241, "scroll.png");
            this.imageList1.Images.SetKeyName(242, "scroll_add.png");
            this.imageList1.Images.SetKeyName(243, "scroll_delete.png");
            this.imageList1.Images.SetKeyName(244, "scroll_error.png");
            this.imageList1.Images.SetKeyName(245, "scroll_information.png");
            this.imageList1.Images.SetKeyName(246, "scroll_ok.png");
            this.imageList1.Images.SetKeyName(247, "scroll_preferences.png");
            this.imageList1.Images.SetKeyName(248, "scroll_refresh.png");
            this.imageList1.Images.SetKeyName(249, "scroll_replace.png");
            this.imageList1.Images.SetKeyName(250, "scroll_run.png");
            this.imageList1.Images.SetKeyName(251, "scroll_stop.png");
            this.imageList1.Images.SetKeyName(252, "scroll_view.png");
            this.imageList1.Images.SetKeyName(253, "scroll_warning.png");
            this.imageList1.Images.SetKeyName(254, "selection.png");
            this.imageList1.Images.SetKeyName(255, "selection_delete.png");
            this.imageList1.Images.SetKeyName(256, "selection_recycle.png");
            this.imageList1.Images.SetKeyName(257, "selection_replace.png");
            this.imageList1.Images.SetKeyName(258, "signpost.png");
            this.imageList1.Images.SetKeyName(259, "star_blue.png");
            this.imageList1.Images.SetKeyName(260, "star_green.png");
            this.imageList1.Images.SetKeyName(261, "star_grey.png");
            this.imageList1.Images.SetKeyName(262, "star_red.png");
            this.imageList1.Images.SetKeyName(263, "star_yellow.png");
            this.imageList1.Images.SetKeyName(264, "star_yellow_add.png");
            this.imageList1.Images.SetKeyName(265, "star_yellow_delete.png");
            this.imageList1.Images.SetKeyName(266, "star_yellow_new.png");
            this.imageList1.Images.SetKeyName(267, "star_yellow_preferences.png");
            this.imageList1.Images.SetKeyName(268, "star_yellow_view.png");
            this.imageList1.Images.SetKeyName(269, "stop.png");
            this.imageList1.Images.SetKeyName(270, "text.png");
            this.imageList1.Images.SetKeyName(271, "text_align_center.png");
            this.imageList1.Images.SetKeyName(272, "text_align_justified.png");
            this.imageList1.Images.SetKeyName(273, "text_align_left.png");
            this.imageList1.Images.SetKeyName(274, "text_align_right.png");
            this.imageList1.Images.SetKeyName(275, "text_binary.png");
            this.imageList1.Images.SetKeyName(276, "text_bold.png");
            this.imageList1.Images.SetKeyName(277, "text_braille.png");
            this.imageList1.Images.SetKeyName(278, "text_find.png");
            this.imageList1.Images.SetKeyName(279, "text_italics.png");
            this.imageList1.Images.SetKeyName(280, "text_lock.png");
            this.imageList1.Images.SetKeyName(281, "text_loudspeaker.png");
            this.imageList1.Images.SetKeyName(282, "text_marked.png");
            this.imageList1.Images.SetKeyName(283, "text_normal.png");
            this.imageList1.Images.SetKeyName(284, "text_ok.png");
            this.imageList1.Images.SetKeyName(285, "text_rich.png");
            this.imageList1.Images.SetKeyName(286, "text_rich_colored.png");
            this.imageList1.Images.SetKeyName(287, "text_rich_marked.png");
            this.imageList1.Images.SetKeyName(288, "text_tree.png");
            this.imageList1.Images.SetKeyName(289, "text_underlined.png");
            this.imageList1.Images.SetKeyName(290, "text_view.png");
            this.imageList1.Images.SetKeyName(291, "transform.png");
            this.imageList1.Images.SetKeyName(292, "transform2.png");
            this.imageList1.Images.SetKeyName(293, "undo.png");
            this.imageList1.Images.SetKeyName(294, "unknown.png");
            this.imageList1.Images.SetKeyName(295, "view.png");
            this.imageList1.Images.SetKeyName(296, "view_next.png");
            this.imageList1.Images.SetKeyName(297, "view_previous.png");
            this.imageList1.Images.SetKeyName(298, "warning.png");
            this.imageList1.Images.SetKeyName(299, "window.png");
            this.imageList1.Images.SetKeyName(300, "window_add.png");
            this.imageList1.Images.SetKeyName(301, "window_colors.png");
            this.imageList1.Images.SetKeyName(302, "window_delete.png");
            this.imageList1.Images.SetKeyName(303, "window_earth.png");
            this.imageList1.Images.SetKeyName(304, "window_edit.png");
            this.imageList1.Images.SetKeyName(305, "window_environment.png");
            this.imageList1.Images.SetKeyName(306, "window_gear.png");
            this.imageList1.Images.SetKeyName(307, "window_information.png");
            this.imageList1.Images.SetKeyName(308, "window_new.png");
            this.imageList1.Images.SetKeyName(309, "window_preferences.png");
            this.imageList1.Images.SetKeyName(310, "window_sidebar.png");
            this.imageList1.Images.SetKeyName(311, "window_split_hor.png");
            this.imageList1.Images.SetKeyName(312, "window_split_ver.png");
            this.imageList1.Images.SetKeyName(313, "window_star.png");
            this.imageList1.Images.SetKeyName(314, "window_time.png");
            this.imageList1.Images.SetKeyName(315, "window_view.png");
            this.imageList1.Images.SetKeyName(316, "window_warning.png");
            this.imageList1.Images.SetKeyName(317, "windows.png");
            this.imageList1.Images.SetKeyName(318, "zoom_in.png");
            this.imageList1.Images.SetKeyName(319, "zoom_out.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MainIface mainIface1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

