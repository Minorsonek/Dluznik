   M S B A M L   `   `   `  ���� E  ADluznikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DluznikWPF
DluznikWPF  J FDluznikWPF.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.CoreDluznikWPF.Core "    DluznikWPF.ConfirmDeletePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:DluznikWPF     Gcore6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.Core     -      DluznikWPF.BasePage`1   Name$
  Page�� N� Title$ ConfirmDeletePage��.��� .+��� 
������  �� Padding$ 30 30q�._��  � RowDefinitions �� $��* ��� $
��Auto �.+���    ForegroundLightBrush#��[   �� CornerRadius$ 10��$ 15q�._�� .+��� $��Czy na pewno ��  WordRedBrush#��[   LatoBold#��[ $
��Wrap=�$��Center=� �� TextAlignment$ Center=�$��Center=�  FontSizeLarge#��[ y��� *IsAnyBorrowerSelected+ �� 	Converter ,   &DluznikWPF.BooleanToVisiblityConverter   �� ConverterParameter$
 True����   WordBlueBrush#��[ ��� *SelectedBorrowerName+ �� $6�0spłacił Ci dług i chcesz go usunąć z listy?���� $I��CŻaden dłużnik nie został wybrany, wróć do poprzedniej strony.��#��[ #��[ $
��Wrap=�$��Center=�$ Center=�$��Center=�#��[ y��� *IsAnyBorrowerSelected+   � $��1�� � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��10q�$��20q�$��
Tak, usuń��	 �� 	IsDefault	 . 
 � Cursor$

 Hand������ *DeleteCommand+y��� *IsAnyBorrowerSelected+   $
 True���� $��10q�$��20q�$��2��$��Powrót��$

 Hand������ *ToMainPageCommand+