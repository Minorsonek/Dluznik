   M S B A M L   `   `   `  ����E  ADluznikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DluznikWPF
DluznikWPF  5      J FDluznikWPF.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.CoreDluznikWPF.Core 5          DluznikWPF.AddPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DluznikWPF     5      Gcore6clr-namespace:DluznikWPF.Core;assembly=DluznikWPF.Core     5      -   5           DluznikWPF.BasePage`1   Name$
  Page��5	       N� Title$ AddPage��5
      .��5      � .+�5   
   �� 
������  �� Padding$ 30 30q�5      ._�5      �  � RowDefinitions 5      �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      ��    ForegroundLightBrush#��[  6    �� CornerRadius$ 10��5      $ 15 50 50 15q�5      ._�5      �� .+�5      �� 
 � Tag$ Imię��6]   ��6"   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6]   �� 5      $ Ilość pieniędzy��6^   ��6"   �� *Value+$ PropertyChanged=�6^   �� 5       $ Dzień pożyczki��6\   ��6"   �� *Day+$ PropertyChanged=�6\   �� 5"      $ Miesiąc pożyczki��6^   ��6"   �� *Month+$ PropertyChanged=�6^   �� 5$      $ Dołączona wiadomość��6`   ��6"   �� *	Message+$ PropertyChanged=�6`   �� 5'        WordRedBrush#��[ 5)   $    �� Padding$ 15q�5*   $     LatoBold#��[ 5+   $   y�5'   $   �� *	ErrorFlag+ �� 	Converter ,   &DluznikWPF.BooleanToVisiblityConverter  	 �� ConverterParameter$
	 True����5(   $   �� *ErrorMessage+5+   $   5-      5/      � 51      $��1��6   
 � ColumnDefinitions
 53      �� 54      $
��Auto �6+   �� 55      $��* �6+   �� 56      $
��Auto �6+   .+�59      �� $��10q�6   $��20q�5:      $��Dodaj��5;       �� 	IsDefault .  � Cursor$
 Hand��5>      ��5<      �� *
AddCommand+5>      �� 5@      $��10q�6   $��20q�5A      $��2��5B      $��Powrót��5C      $
 Hand��5E      ��5D      �� *ToMainPageCommand+5E      5G      5I      5J      5K      5L      