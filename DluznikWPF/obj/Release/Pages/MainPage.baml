   M S B A M L   `   `   `  ���� E  ADluznikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DluznikWPF
DluznikWPF  J FDluznikWPF.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.CoreDluznikWPF.Core     DluznikWPF.MainPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:DluznikWPF     Gcore6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.Core     -      DluznikWPF.BasePage`1   Name$
  Page�� N� Title$ MainPage��.���� 
������  �� Padding$ 30 30q�._��  � RowDefinitions �� $��* ��� $
��Auto �.+���    ForegroundLightBrush#��[   �� CornerRadius$ 10��$ 15q�#  DluznikWPF.Core.ListViewModel   Instance � DataContext# Z ._��� $
��Auto=�.���� ���� *Items+���� .R�    DluznikWPF.ListItemControl  � $��1�� � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��10q�$��20q�$��Dodaj�� � Cursor$
 Hand������ *ToAddPageCommand+�� $��2��$��20q�$��10q�$��Usuń��$
 Hand������ *ToConfirmDeletePageCommand+�� $#��Aktualnie nie ma dłużników��  WordRedBrush#��[   LatoBold#��[ $
��Wrap=�$��Center=�	 �� TextAlignment$	 Center=�$��Center=�  FontSizeLarge#��[ y��� *IsItemsEmpty+
 �� 	Converter
 ,   &DluznikWPF.BooleanToVisiblityConverter   �� ConverterParameter$
 True��