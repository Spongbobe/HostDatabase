   M S B A M L   `   `   `  ����A  =TestIQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestIQTestIQ  5   	       TestIQ.DbWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:TestIQ     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ DbWindow��5
   	   $	��550��6   $	��800��6'   .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $	��400 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��500��6   $��30��5      $��15(�5      $	��6 3q�5      $
��Left=�5      $��	10 30 0 0q�5      .��6)   5      �� 5      -   5         ��Name$ 
selectFile��5      $	��...��5      $��20(�6#   $��30��5      $��0 -8 0 0q�5      $��	15 30 0 0q�5      $��30��5!      5#      5$      �� 5'   
   -   5         ��Name$ dbList��5+      $��1��5'      $��10q�5(      $��1q�5)      
���   ���5,      �� 5-      .R�5.      �� $ 
Horizontal=�6!   .+�50      �� $
��Wrap=�6>   $��16(�51   $   ��50   $   �� *
Question+54      �� 55      $
��Wrap=�6Y    �� Padding$ 20 0 0 0q�56   $   
���  ��$��16(�58   $   ��55   $   �� *Answer+ �� StringFormat$ anwer : ({0})��58   $   59      5:      5=      5?      5@      