   M S B A M L   `   `   `  ����S  OLibraryManagementProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryManagementProjectLibraryManagementProject  5   	   $    LibraryManagementProject.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LibraryManagementProject     5   	     � Title$  
SignInPage��5   	   $	��600��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��1��6    5      �� 5      $��0* �6'   �� 5       � RowDefinitions 5      �� 5      $
��113* �6$   �� 5      $	��64* �6$   �� 5      $	��71* �6$   �� 5      $	��50* �6$   �� 5      $	��79* �6$   �� 5      $	��80* �6$   �� 5      $
��160* �6$   .+�5      �� $
��Left=�6   $��1��67   $
��Wrap=�6D   $��UserName��6X   $	��Top=�6h   $��22(�6�   $
��Bold"�6�   $	��338��6�   $��38��6�   $��0,23,0,0q�6�   $��2��6�   �� 5       -   5        $
��Left=�5       $��2��65    �� TextWrapping$
 Wrap=�6B   $	��Top=�6V   $	��338��6n   $��38��6z    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��0,9,0,0q�6�   $��2��6�   .��6�   z�5"      V� 5#      .~�5$      ��  �� ScaleY$ -1Q�6-   �� 5%      �� 5&      T� 5'      5(      .��5)   /   5*      �� 5+      $
��Left=�6   $��3��68   $
��Wrap=�6E   $��Password��6Y   $��Center=�6i   $��22(�6�   $
��Bold"�6�   $	��338��6�   $��38��6�   $��2��6�   �� 5,      -   5        $
��Left=�5,      $��0,2,0,0q�66   $��4��6G   $
 Wrap=�6T   $	��Top=�6h   $	��338��6�   $��38��6�   $��2��6�   �� 5.      -   5        $��SIGN IN��5/   -   $
��Left=�6?   $��6,10,0,0q�6Z   $��5��6l   $	��Top=�6y   $��22(�6�   $
��Bold"�6�   $	��314��6�   $��38��6�   
��� E��$��2��6�   ���	#FFFEF7F76�   �� 50      -   5        $#��Don't have an account create?��50   3   ���	#FF52ADA4$
��Left=�6r   $��6,6,0,0q�6�   $��6��6�   $	��Top=�6�   $��22(�6�   $��38��6�   $	��314��6�   $��2��6�   ���	#FFFEF7F76�   51      �� 52      $
��Left=�6   $	��100��6/   $��152,244,0,0q�6<   $	��Top=�6Q   $	��100��6i   � 53      $��0,0,24,0q�6    54      �� 55      $
��271* �6$   .+�57      � ��58      �� 59       �� ImageSource$% /BookImage-removebg-preview.png��6%    5;      �� 5<      $	��21* �6(   �� 5=      $
��125* �6(   .+�5?      �� $
��Left=�6    $��	10,-5,0,0q�6;   $
��Wrap=�6N   $��BookLibrary��6b   $	��Top=�6u   ���	#FF52ADA4$��48(�6�   $��Mistral)�6�   $	��347��6�   5@      5A      5B      5D      5E      