   M S B A M L   `   `   `  ����O  KAssignment3.3.2_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Assignment3._3._2_MVVMAssignment3._3._2_MVVM  5   	   '    !Assignment3._3._2_MVVM.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Assignment3._3._2_MVVM     5   	     � Title$  Students��5   	   $	��450��6   $	��980��6'   .��5	      � $��5q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Student ID:��6-   $��5q�6C   $��Right=�6N   $��Center=�6j   �� 5   
   -   5         ��Name$ 	studentId��5   /   $��0��6   $��1��6   $
��Left=�6B    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $��5q�6y   $��Center=�6�   $	��120��6�   �� 5   
   $��1��6   $��0��6   $��First Name:��6-   $��5q�6C   $��Right=�6N   $��Center=�6j   �� 5   
   -   5        $ 	firstName��5   /   $��1��6   $��1��6   $
��Left=�6B   $��5q�6]   $
 Wrap=�6h   $�� ��6|   $��Center=�6�   $	��120��6�   �� 5!   
   $��2��6   $��0��6   $��
Last Name:��6-   $��5q�6B   $��Right=�6M   $��Center=�6i   �� 5"   
   -   5        $ lastName��5"   /   $��2��6   $��1��6   $
��Left=�6A   $��5q�6\   $
 Wrap=�6g   $�� ��6{   $��Center=�6�   $	��120��6�   �� 5$   
   $��3��6   $��0��6   $��Address:��6-   $��5q�6@   $��Right=�6K   $��Center=�6g   �� 5%   
   -   5        $ address��5%   /   $��3��6   $��1��6   $
��Left=�6@   $��5q�6[   $
 Wrap=�6f   $�� ��6z   $��Center=�6�   $	��120��6�   �� 5'   
   $��4��6   $��0��6   $��Month of Admission:��6-   $��5q�6K   $��Right=�6V   $��Center=�6r   �� 5(   
   -   5        $ month��5(   /   $��4��6   $��1��6   $
��Left=�6>   $��5q�6Y   $
 Wrap=�6d   $�� ��6x   $��Center=�6�   $	��120��6�   �� 5*   
   $��5��6   $��0��6   $
��GPA:��6-   $��5q�6<   $��Right=�6G   $��Center=�6c   �� 5+   
   -   5        $	 gpa��5+   /   $��5��6   $��1��6   $
��Left=�6<   $��5q�6W   $
 Wrap=�6b   $�� ��6v   $��Center=�6~   $	��120��6�   �� 5-   
   -   5         ��Name$ 
addStudent��5-   .   $��6��6   $��1��6   $��Add New Student��6B   $��5q�6\   $
��Left=�6g   $	��Top=�6�   6�   �� 5/   
   -   5         ��Name$ studentListView��5/   A   $��0��6   $��2��6    $��8��60   $��5q�6~   ��6Z   �� *StudentList+ �� View 50      �� 51      .P�52      �� $��
Student ID��6%    �� Width$	 100��6d   	 �� DisplayMemberBinding	 69   �� *	StudentId+6d   �� 53      $��
First Name��6%   $	 100��6d   	 69   �� *	FirstName+6d   �� 54      $��	Last Name��6%   $	 100��6b   	 68   �� *
LastName+6b   �� 55      $��Address��6%   $	 150��6_   	 66   �� *	Address+6_   �� 56      $��Month of Admission��6%   $	 150��6s   	 6A   �� *MonthOfAdmission+6s   �� 57      $	��GPA��6%   $ 50��6W   	 62   �� *GPA+6W   58      5:      �� 5;   
   -	   5        $��7��5;      $��1��6   $��Delete Selected Student��6.   $
��Left=�6t   $��5q�6�   $	��Top=�6�   5<      5=      