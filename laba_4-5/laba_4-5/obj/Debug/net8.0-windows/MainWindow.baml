   M S B A M L   `   `   `  ����C  ?laba_4-5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:laba_4_5laba_4_5  5   	       laba_4_5.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:laba_4_5     5   	   -   5          � Title$  PCMasterCreator��5	   	   $	��800��6!   $
��1200��6.    � WindowStartupLocation$ CenterScreen=�6;    � Icon$ /appIcon.ico��6�   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��8* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��1��6"   $��1��62   .+�5      � $��0 0 0 10q�6   .+�5      ��    m_MainTitle_TextBlock#���   6   $��Center=�6K   $��32(�6h    " TextBlock_StyleFonts_BlackBold#���  5      �� 5      -   5         ��Name$ RegistrationButton��5        m_LogOrReg_Button#���  65   $��Right=�5      $��Bottom=�65    ! FlatButtonDesign_RegularStyle#���  5      6Q   5!      � 5#      .+�5$      �� -   5         ��Name$ Catalog��5$        m_Catalog_ComboBox)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6,   $	��100��6r   $��10 0 0 0q�6~   $
��Left=�5%         CatalogComboBox_RegularStyle#���  66   .@�5&      ��   m_CPUcase_TextBlock#���  6     % !TextBlock_StyleFonts_BlackRegular#���  6M   �� 5'        m_GPUcase_TextBlock#���  6    #���  6M   5)      �� 5+      -   5        $ 
AddNewItem��5+       	 m_AddNewItem_Button#��� 	 6-   $��	150 0 0 0q�6]   $
��Left=�5,      $��Bottom=�64     
 FlatButtonDesign_MediumStyle#��� 
 5-      6P   �� 5/      -   5         ��Name$ Search��5/        m_Search_TextBox# �  6*   $	��120��6n   $��0 0 10 0q�6z   $��Right=�50       $  FloatingHintTextBox_RegularStyle#���  51      6U   54      55      �� 57   
   $��0��6   $��0��6   $��3��6.   
�������$��1q�6W    � 59   
   -   5        	  �Name$	 	MainFrame��59      $��1��6#   $��1��60   $��	0,10,0,10q�6@   
  � NavigationUIVisibility$
 Hidden=�6S   �� 5;   
   $��2��6   $��0��6"   $��3��62   
���   �.+�5=      � -   5         �Name$ LanguageSettings��5=      $��Center=�6-   $	��135��6q    � Cursor$
 Hand��6}   .+�5?      �� -   5         ��Name$ Language��5?      $��18(�6.     m_Language_TextBlock#���  6<   
�������$��0 15 0 0q�5@   /   $
��Left=�5A      $��Center=�67     TextBlock_RegularStyle#���  5B      �� 5D      -	   5        $ 
LanguageID��5D      $��18(�60     m_LanguageID_TextBlock#���  6>   ���#C83B1D$��0 15 0 0q�5E   1   $��Right=�5F      $��Center=�68   #���  5G      5H      � 5J      -
   5        $ LanguageChoise��5J      $	��120��6+   $��Center=�67   $��0 5 0 0q�6T   .+�5L      �� -   5        $ ru_Language��5L         m_LanguageButtonRU_TextBlock#���  61   $��14(�5M      $��Right=�6*   
�������$y�Hidden=�5N      $
 Hand��60   #���  5O      5P      �� 5R      -   5        $ en_Language��5R         m_LanguageButtonEN_TextBlock#���  61   $��14(�5S      $
��Left=�6*   ���#C83B1D$y�Hidden=�5T      $
 Hand��60   #���  5U      5V      5W      � 5Y      -   5        $ 
AboutAutor��5Y      $��25��6'   $��
0 -10 0 0 q�63   .+�5[      �� -   5        $ LinkToVK��5[        m_AboutAutor_TextBlock#���  6.   $��12(�5\      $
 Hand��6*   ���	#FFC9C9C9
���   �$��Center=�5]      $	��Top=�69   #���  5^      5_      5`      5b      5c      5d      