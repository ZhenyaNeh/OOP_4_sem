   M S B A M L   `   `   `  ����A  =laba_6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:laba_6laba_6  5   	       laba_6.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:laba_6     5   	   -   5          � Title$  PCMasterCreator��5	   	   $	��800��6!   $
��1200��6.    � WindowStartupLocation$ CenterScreen=�6;    � Icon$ /appIcon.ico��6�    � 	Resources 5         Flat �� 
TargetType  laba_6.CastomCheckBox �� 
TargetType �� Property �� Value �� Orientation	 �� CornerRadius
 ��Name'  !MaterialDesignThemes.Wpf.PackIcon  Name   Kind ��Name � 	Resources  Key �� TargetProperty �� 
TargetName g� Duration t� From	 t� To t� EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode �� Triggers P� Property P� Value N� ExitActions �� BeginStoryboardName ��Name 	 right �� 
TargetName  left��%u  &	        '  o     7  7  �� 5   
   " ��6'   .R�5      �� $��0,0,0,0q�6   ._�5      �� 
����� �6!   5      5      �� 5   
   "  6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 
Horizontal=�6%   .+�5      � .+�5   "   �� $��45��6)   $��20��64   
�������$	 10��6W   $	��4,0q�6i   6x   �� 5   "   $
 button��6)   $��17��69   $��17��6E   $
	 12.5��6P   $
��Left=�6d   $��6,0,0,0q�6   ._�5   &     $ 
buttonIcon��6>   $ WbSunny=�6R   $��14��6a   $��14��6m   $��1.4,1.8,0,0q�6x   5   #   5      �� 5      $ content��6/   $��10,0,0,0q�6@   #��z��6R   $��Center=�6v   5       5      ���� 5       	right .��5!   "   t� $ Margin�65   $ button��6X   $ 0:0:0.4D�6w    6,0,0,06�    30,0,0,06�    5"   &     5#   *   $ EaseOut=�65   5%   #   5&      �� 5'      left .��5(   "   t� $ Margin�65   $ button��6X   $ 0:0:0.4D�6w    30,0,0,06�    6,0,0,06�    5)   &     5*   *   $ EaseOut=�65   5,   #   5-      5.       5/      P� 50       �@d�	IsChecked$ falseY�6;    51   "   �� 52   &   $ leftt��67   6U   �� 53   &   $ rightt��6Z   8��  6m   . �55   "   �� $ button��6)    � �� �#7575756e   56      P� 57       �@d�	IsChecked$
 trueY�6;    58   "   �� 59   &   $ rightt��67   6V   �� 5:   &   $ leftt��6Y   8�� 6k   . �5<   "   �� $ button��6)    � �� �#7575756S   �� 5=   "   $ 
buttonIcon��6)    �@ Kind$ WeatherNight=�6Q   5>      5@      5B      5C      5G      .��5I      �   LightThemeBackground_Grid#���  6    � ColumnDefinitions 5J   
   �� 5K      $��1* �6   �� 5L      $��6* �6   �� 5M      $��1* �6    � RowDefinitions 5P   
   �� 5Q      $	��100 �6   �� 5R      $��8* �6   �� 5S      $	��100 �6   .+�5V   
   �� $��0��6   $��1��6"   $��1��62   .+�5W      � $��0 0 0 10q�6   .+�5X        -   5          Name$ Theme��5X   '      laba_6.CastomCheckBox    Click$  Theme_Click��6Q   $
��Left=�66   6Q   �� 5Z        m_MainTitle_TextBlock#��[ 6   $��Center=�6J   $��32(�6g    " TextBlock_StyleFonts_BlackBold#���  5[      �� 5]      -   5        ! ��Name$! RegistrationButton��5]        m_LogOrReg_Button#���  65   $��Right=�5^      $��Bottom=�65    ! FlatButtonDesign_RegularStyle#���  5_      6Q   5a      � 5c      .+�5d      �� -   5        " ��Name$" Catalog��5d       	 m_Catalog_ComboBox)  #MaterialDesignThemes.Wpf.HintAssist#   Hint## � 	 6,   $	��100��6r   $��10 0 0 0q�6~   $
��Left=�5e        
 CatalogComboBox_RegularStyle#��� 
 66   .@�5f      ��   m_CPUcase_TextBlock#���  6     % !TextBlock_StyleFonts_BlackRegular#���  6M   �� 5g        m_GPUcase_TextBlock#���  6    #���  6M   5i      �� 5k      -   5        $! 
AddNewItem��5k        m_AddNewItem_Button#���  6-   $��	150 0 0 0q�6]   $
��Left=�5l      $��Bottom=�64      FlatButtonDesign_MediumStyle#���  5m      6P   �� 5o      -   5        $ ��Name$$ Search��5o        m_Search_TextBox## �  6*   $	��120��6n   $��0 0 10 0q�6z   $��Right=�5p       $  FloatingHintTextBox_RegularStyle#���  5q      6U   5t      5u      �� 5w   
   $��0��6   $��0��6   $��3��6.   
�������$��1q�6W    � 5y   
   -   5        %  �Name$% 	MainFrame��5y      $��1��6#   $��1��60   $��	0,10,0,10q�6@   &  � NavigationUIVisibility$& Hidden=�6S   �� 5{   
   $��2��6   $��0��6"   $��3��62   
���   �.+�5}      � -   5        ' �Name$' LanguageSettings��5}      $��Center=�6-   $	��135��6q   ( � Cursor$
( Hand��6}   .+�5      �� -	   5        ) ��Name$) Language��5      $��18(�6.     m_Language_TextBlock#���  6<   
�������$��0 15 0 0q�5�   /   $
��Left=�5�      $��Center=�67     TextBlock_RegularStyle#���  5�      �� 5�      -
   5        $) 
LanguageID��5�      $��18(�60     m_LanguageID_TextBlock#���  6>   ���#C83B1D$��0 15 0 0q�5�   1   $��Right=�5�      $��Center=�68   #���  5�      5�      � 5�      -   5        $' LanguageChoise��5�      $	��120��6+   $��Center=�67   $��0 5 0 0q�6T   .+�5�      �� -   5        $) ru_Language��5�         m_LanguageButtonRU_TextBlock#���  61   $��14(�5�      $��Right=�6*   
�������$y�Hidden=�5�      $
( Hand��60   #���  5�      5�      �� 5�      -   5        $) en_Language��5�         m_LanguageButtonEN_TextBlock#���  61   $��14(�5�      $
��Left=�6*   ���#C83B1D$y�Hidden=�5�      $
( Hand��60   #���  5�      5�      5�      � 5�      -   5        $' 
AboutAutor��5�      $��25��6'   $��
0 -10 0 0 q�63   .+�5�      �� -   5        $) LinkToVK��5�        m_AboutAutor_TextBlock#���  6.   $��12(�5�      $
( Hand��6*   ���	#FFC9C9C9
���   �$��Center=�5�      $	��Top=�69   #���  5�      5�      5�      5�      5�      5�      