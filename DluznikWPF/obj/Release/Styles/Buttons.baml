   M S B A M L   `   `   `  ���� E  ADluznikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DluznikWPF
DluznikWPF  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source �� 
TargetType   	Hoverless �� Property �� Value �� 
TargetType �� Padding  SystemIconButton �� BasedOn'   !System.Windows.Shell.WindowChrome  WindowControlButton  	BaseStyle  ForegroundMainBrush �� ScaleX	 �� Triggers
 P� Property P� Value  BackgroundLightBrush  WindowCloseButton  ForegroundLightBrush  WordOrangeBrush 	 FontSizeLarge 
 LatoRegular�   �DluznikWPF.BaseAttachedProperty`2[[DluznikWPF.IsBusyProperty, DluznikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] ��Name �� CornerRadius J� SnapsToDevicePixels �� 	Converter,   &DluznikWPF.BooleanToVisiblityConverter  SpinningText �� ConverterParameter �� Triggers :� RoutedEvent  WordDarkRed	 �� To g� Duration �� 
TargetName �� TargetProperty  
WordOrange �� 
TargetName  ForegroundDarkBrush  
TextButton  FontSizeRegular  
IconButton  WordRedBrush  FontAwesome �� RelativeSource  WordRed�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     "localclr-namespace:DluznikWPF    �� $ Colors.xaml?��� $ 
Fonts.xaml?��� $ 
Texts.xaml?�%3
  &	        &	 �     7   &	 �     7  7  7  &	 >    7  7  '�� �    7  7  7  7 	 7 
 7  7  7  7  &	 w    7  7  7  7 
 7  7  &	     7  7  7  7 	 7  7  7  7  �� " ��.���  � ��
 ���� ��  � ��$ 0q���  � �� �� " ��.R��� # z��#��z��._��� $��Center=�$��Center=��� " ��8   .���   �@  IsHitTestVisibleInChrome . ��  � ��$ 10q��� " ��8   .���   �@  IsHitTestVisibleInChrome . ��  � ��
 ���� ��  � ��$ 8q���  � ��$ Stretch=���  � ��8  ��  �@�LayoutTransform �� $	 1.5Q���  � �� �� " ��.R��� # z��#��z��._��� $��Center=�$��Center=�#��z��	 P� 
 �@J�IsMouseOver . . ���  � ��8  �� " ��8   	 P� 
 �@J�IsMouseOver . . ���  � ��
 �  ����  � ��8  �� " ��8   .���  � ��8  ��  � ��8  ��  � ��$ 0q���  � ��8  ��  � ��8  ��  � ��$ 50 10q���  � ��$
 0 10q���  �@ Value .  ��  � �� �� " ��.R��� $ border��$ 10��#��z��#��z��#��z�� . ._�� .+��� #��z��|�.  #��z��#��z��#��z��# z #��z��y��� *local:IsBusyProperty.Value+   �� 8�� #��z��#��z��y��� *local:IsBusyProperty.Value+   $
 True�� :� $ 
MouseEnter��.[��� .���� .���� 8  $ 0:0:0.3D�$ border��$ Background.Color�:� $ 
MouseLeave��.[��� .���� .���� 8  $ 0:0:0.3D�$ border��$ Background.Color�P� 
 � {� .  . ��� $ border��8   � ���� " ��8   .���  � ��
 ���� ��  � ��8  ��  � ��$ 0q���  � ��8  ��  � ��8  ��  � ��$ 50 10q���  � ��$
 0 10q���  � �� �� " ��.R��� $ border��$ 10��#��z��#��z��#��z�� . ._��� #��z��|�.  #��z��#��z��#��z��# z #��z�� P� 
 �@J�IsMouseOver . . ��� 8   � ��P� 
 � {� .  . ��� 8   � ���� " ��8   .���  � ��8  ��  � ��8  ��  � ��$ 0q���  � ��8  ��  � ��8  ��  � ��$ 30q���  � ��$ 0q���  � �� �� *ActualHeight+ �� *Self+��  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . ._�� .+�(� .���� #��z��|�.  #��z��#��z��#��z��# z #��z�� :� $ 
MouseEnter��.[��� .���� .���� 8  $ 0:0:0.3D�$ border��$ Background.Color�:� $ 
MouseLeave��.[��� .���� .���� 8  $ 0:0:0.3D�$ border��$ Background.Color�P� 
 � {� .  . ��� $ border��8   � ��