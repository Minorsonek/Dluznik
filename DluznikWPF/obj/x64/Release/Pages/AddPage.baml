   M S B A M L   `   `   `  ���� B  >Dluznik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DluznikWPF
DluznikWPF  J FDluznikWPF.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.CoreDluznikWPF.Core     DluznikWPF.AddPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:DluznikWPF     Gcore6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.Core     -      DluznikWPF.BasePage`1   Name$
  Page�� N� Title$ AddPage��.��� .+��� 
������  �� Padding$ 30 30q�._��  � RowDefinitions �� $��* ��� $
��Auto �.+���    ForegroundLightBrush#��[   �� CornerRadius$ 10��$ 15 50 50 15q�._��� .+��� 
 � Tag$ Imię������ *Name+ �� UpdateSourceTrigger$ PropertyChanged=��� $ Ilość pieniędzy������ *Value+$ PropertyChanged=��� $ Dzień pożyczki������ *Day+$ PropertyChanged=��� $ Miesiąc pożyczki������ *Month+$ PropertyChanged=��� $ Dołączona wiadomość������ *	Message+$ PropertyChanged=���   WordRedBrush#��[  �� Padding$ 15q�  LatoBold#��[ y��� *	ErrorFlag+ �� 	Converter ,   &DluznikWPF.BooleanToVisiblityConverter  	 �� ConverterParameter$
	 True������ *ErrorMessage+� $��1��
 � ColumnDefinitions
 �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��10q�$��20q�$��Dodaj�� �� 	IsDefault .  � Cursor$
 Hand������ *
AddCommand+�� $��10q�$��20q�$��2��$��Powrót��$
 Hand������ *ToMainPageCommand+