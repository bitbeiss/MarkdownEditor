   M S B A M L   `   `   `  ���� C  ?Svg2Xaml, Version=0.3.0.5, Culture=neutral, PublicKeyToken=null5(clr-namespace:Svg2Xaml;assembly=Svg2XamlSvg2Xaml   Markdown_Editor    Markdown_Editor.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     C ?Fluent, Version=6.1.0.326, Culture=neutral, PublicKeyToken=nullFluenturn:fluent-ribbon  7svg2xaml(clr-namespace:Svg2Xaml;assembly=Svg2Xaml    � Title$  Markdown Editor��$
��1600��$	��600��.���  � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $
��Auto ��� $��* �.+�  Fluent.Ribbon  $��0��   Tabs.   Fluent.RibbonTabItem     Header$
 Home��   Groups.   Fluent.RibbonGroupBox     Header$
 Load��.@�  Fluent.Button  -     Name$ btnLoad��   Header$
 load��	   	LargeIcon$	 Images/load.png��  -   $ btnNewInstance��$ new instance��	     Svg2Xaml.SvgImageExtension  *Images/new_instance.svg+  $
 File��.@�  -   $ btnSave��$
 save��$	 Images/save.png��  -   $ 	btnSaveAs��$ save as��$	 Images/save_as.png��  -   $ btnUndo��$
 undo��	   *Images/undo.svg+  -   $ btnRedo��$
 redo��	   *Images/redo.svg+  -   $ 
btnDisplay��$ display��	   *Images/display.svg+  $ Format��.   $ 	Highlight��.@�  -   $ btn_bold��$
 Bold��	   *Images/format_bold.svg+  -	   $ 
btn_italic��$ Italic��	   *Images/format_italic.svg+  $
 Code��.@�  -
   $ btn_mark_code��$ Mark as code��	   *Images/laptop_windows.svg+  $ Lists��.@�  -   $ btn_list��$ Format as list��	   *Images/format_list.svg+  -   $ btn_numberd_list��$ Format as numberd list��	   *!Images/format_list_numbered.svg+  $ 	Structure��.   $ Break and separate��.@�  -   $ btn_seperator��$ 	Seperator��	   *Images/space_bar.svg+  -   $ btn_linebreak��$ 	Linebreak��	   *Images/keyboard_return.svg+  -   $ btn_paragraph��$ Clause��	   *Images/paragraph.svg+  $ Headings��.@�  Fluent.DropDownButton  -   
  Name$
 ddbtn_Heading��   Header$ Headings��   	LargeIcon$ Images/header1_100.png��@�  Fluent.MenuItem  -   $��Heading 1.Level��  -   $��Heading 2.Level��  -   $��Heading 3.Level��  -   $��Heading 4.Level��  -   $��Heading 5.Level��  -   $��Heading 6.Level��  $ Quote��.@�  -   $ 	btn_quote��$ Quote��	   *Images/format_quote.svg+  -   $ btn_unquote��$ Unquote��	   *Images/cancel.svg+  $ Insert��.   $ Media��.@�  -   $ btn_insert_photo��$ Insert photo��	   *Images/insert_photo.svg+  $
 Link��.@�  -   $ btn_insert_hyperlink��$ Insert hyperlink��	   *Images/insert_link.svg+  -   $ btn_insert_table��$ Insert table��	   *Images/format_grid.svg+�� -    ��Name$ rtbMainText��$��0��$��1��$
��Left=�$��Stretch=�$
��Auto��$��	0,0,0,0.5q�$
��Auto��. �/� .T�J� .*�.*��� $�RichTextBox��(  "System.Windows.Controls.WebBrowser  -     Name$ 
webBrowser��$��1��$��1��$��Stretch=�$��Stretch=�$
��Auto��$��	0,0,0,0.5q�$
��Auto��