   M S B A M L   `   `   `  ����E  ADluznikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DluznikWPF
DluznikWPF  5      J FDluznikWPF.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.CoreDluznikWPF.Core 5          DluznikWPF.MainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DluznikWPF     5      Gcore6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.Core     5      -   5           DluznikWPF.BasePage`1   Name$
  Page��5	       N� Title$ MainPage��5      .��5      �� 
������  �� Padding$ 30 30q�5      ._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      ��    ForegroundLightBrush#��[  6    �� CornerRadius$ 10��5      $ 15q�5      #  DluznikWPF.Core.ListViewModel   Instance � DataContext# Z 5      ._�5      �� $
��Auto=�6   .��5      �� ��6#   �� *Items+��5      �� 5       .R�5!   "       DluznikWPF.ListItemControl  5"      5$      5%      5'      � 5)      $��1��6    � ColumnDefinitions 5*      �� 5+      $
��Auto �6'   �� 5,      $��* �6'   �� 5-      $
��Auto �6'   .+�50      �� $��10q�6   $��20q�51      $��Dodaj��52       � Cursor$
 Hand��54      ��53      �� *ToAddPageCommand+54      �� 56      $��2��6   $��20q�57      $��10q�58      $��Usuń��59      $
 Hand��5;      ��5:      �� *DeleteCommand+5;      5=      �� 5@      $#��Aktualnie nie ma dłużników��6     WordRedBrush#��[ 5A        LatoBold#��[ 5C      $
��Wrap=�5D      $��Center=�5E      	 �� TextAlignment$	 Center=�5F      $��Center=�5G        FontSizeLarge#��[ 5H      y�5B      �� *IsItemsEmpty+
 �� 	Converter
 ,   &DluznikWPF.BooleanToVisiblityConverter   �� ConverterParameter$
 True��5H      5J      5K      5L      