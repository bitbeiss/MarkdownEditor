   M S B A M L   `   `   `  ����C  ?Svg2Xaml, Version=0.3.0.5, Culture=neutral, PublicKeyToken=null5(clr-namespace:Svg2Xaml;assembly=Svg2XamlSvg2Xaml  5       Markdown_Editor    Markdown_Editor.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      C ?Fluent, Version=6.1.0.326, Culture=neutral, PublicKeyToken=nullFluenturn:fluent-ribbon  5      7svg2xaml(clr-namespace:Svg2Xaml;assembly=Svg2Xaml  5        � Title$  Markdown Editor��5      $
��1600��5      $	��600��5      .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
     Fluent.Ribbon  $��0��6      Tabs. 5        Fluent.RibbonTabItem     Header$
 Home��6#      Groups. 5        Fluent.RibbonGroupBox     Header$
 Load��6(   .@�5        Fluent.Button  -   5          Name$ btnLoad��5   $      Header$
 load��65   	   	LargeIcon$	 Images/load.png��6C   6_     5      -   5        $ btnNewInstance��5   $   $ new instance��6<   	 6R       Svg2Xaml.SvgImageExtension  *Images/new_instance.svg+6�   5         5!      $
 File��6(   .@�5"        -   5        $ btnSave��5"   $   $
 save��65   $	 Images/save.png��6C   6_     5#      -   5        $ 	btnSaveAs��5#   $   $ save as��67   $	 Images/save_as.png��6H   6g     5$      -   5        $ btnUndo��5$   $   $
 undo��65   	 6C     *Images/undo.svg+6s     5%      -   5        $ btnRedo��5%   $   $
 redo��65   	 6C     *Images/redo.svg+6s     5&      -   5        $ 
btnDisplay��5&   $   $ display��68   	 6I     *Images/display.svg+6|   5'        5(      $
 edit��6(   .@�5)      �� $��0,10,0,0q�6!   .+�5*        Fluent.TextBox  -   5        
  Name$
 txbFind��5*   )      Header$ Find:      ��6:   $	��200��6O   6[     5+      -	   5        $
 
txbReplace��5+   )   $ Replace:��6=   $	��200��6O   $��10q�6[   5,        5-      -
   5        $ btnFind��5-   $   $
 Find��65   	 6C     *Images/find.svg+6s     5.      -   5        $ 
btnReplace��5.   $   $ Replace��68   	 6I     *Images/replace.svg+6|   5/      50        51      $ Format��6#   . 52        $ 	Highlight��6(   .@�53        -   5        $ btn_bold��53   $   $
 Bold��66   	 6D     *Images/format_bold.svg+6{     54      -   5        $ 
btn_italic��54   $   $ Italic��68   	 6H     *Images/format_italic.svg+6�   55        56      $
 Code��6(   .@�57        -   5        $ btn_mark_code��57   $   $ Mark as code��6;   	 6Q     *Images/laptop_windows.svg+6�   58        59      $ Lists��6(   .@�5:        -   5        $ btn_list��5:   $   $ Format as list��66   	 6N     *Images/format_list.svg+6�     5;      -   5        $ btn_numberd_list��5;   $   $ Format as numberd list��6>   	 6^     *!Images/format_list_numbered.svg+6�   5<      5=        5>      $ 	Structure��6#   . 5?        $ Break and separate��6(   .@�5@        -   5        $ btn_seperator��5@   $   $ 	Seperator��6;   	 6N     *Images/space_bar.svg+6�     5A      -   5        $ btn_linebreak��5A   $   $ 	Linebreak��6;   	 6N     *Images/keyboard_return.svg+6�     5B      -   5        $ btn_paragraph��5B   $   $ Clause��6;   	 6K     *Images/paragraph.svg+6�   5C        5D      $ Headings��6(   .@�5E        Fluent.DropDownButton  -   5          Name$ ddbtn_Heading��5E   ,      Header$ Headings��6C      	LargeIcon$ Images/header1_100.png��6U   @�5F        Fluent.MenuItem  5G      -   5        $��Heading 1.Level��5G   .   6f     5H      -   5        $��Heading 2.Level��5H   .   6f     5I      -   5        $��Heading 3.Level��5I   .   6f     5J      -   5        $��Heading 4.Level��5J   .   6f     5K      -   5        $��Heading 5.Level��5K   .   6f     5L      -   5        $��Heading 6.Level��5L   .   6f   5N      5O        5P      $ Quote��6(   .@�5Q        -   5        $ 	btn_quote��5Q   $   $ Quote��67   	 6F     *Images/format_quote.svg+6�   5R      5S        5T      $ Insert��6#   . 5U        $ Media��6(   .@�5V        -   5        $ btn_insert_photo��5V   $   $ Insert photo��6>   	 6T     *Images/insert_photo.svg+6�   5W        5X      $
 Link��6(   .@�5Y        -   5        $ btn_insert_hyperlink��5Y   $   $ Insert hyperlink��6B   	 6\     *Images/insert_link.svg+6�     5Z      -   5        $ btn_insert_table��5Z   $   $ Insert table��6>   	 6T     *Images/format_grid.svg+6�   5[      5\      5_      �� 5a   
   -   5         ��Name$ rtbMainText��5a      $��0��6+   $��1��6;   $
��Left=�6H   $��Stretch=�6c   $
��Auto��6   $��	0,0,0,0.5q�6�   $
��Auto��6�    � 	Resources 5b       �� 
TargetType �� Property �� Value��%X   'J�       �� 5c      " J�6   .�5d      ��  �@��Margin$ 0q�6/   5e      5f      . �5g      /� .T�5h      J� .*�6   .*�5i      �� $�RichTextBox��6   5j      5k      5l      (	  "System.Windows.Controls.WebBrowser	  5m   
   -    5         	 Name$ 
webBrowser��5m      $��1��6)   $��1��69   $��Stretch=�6F   $��Stretch=�6d   $
��Auto��6�   $��	0,0,0,0.5q�6�   $
��Auto��6�   5n      5o      5p      