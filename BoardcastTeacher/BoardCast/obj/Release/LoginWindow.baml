   M S B A M L   `   `   `  ����   	Boardcast    BoardCast.LoginWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  Login�� � SizeToContent$ WidthAndHeight=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�$	��350��$��450.625��.��� $	��400��$	��300�� � RowDefinitions �� $	��37* ��� $	��20* �.+��� $��Images/LoginBG.jpg��$��UniformToFill=�$��
0,-28,0,-2q�$��2���� $��Images/BCLogo.jpg��$��60,19,63,118q��� -    ��Name$ wrongeDetails��$��wronge details��$��	0,100,0,0q�
���   �$y�Hidden=�$��Normal&�$��FontAwesome)�$��Normal$�$��Normal"�$��28��$��Center=�$��Center=�$	��126���� -   $��label2��$��	User Name��$��
14,220,0,0q�$��30��$	��Top=�$
��Left=�$��78��
���   ��� -   $��txtBxuserName��$��	85,0,0,12q�$��30��$��Center=�$��Bottom=�$
��Left=�$	��193��$��FontAwesome)�
������� J� OpacityMask
 �����
��� ���
���   ��� -   $��label3��$��Password��$��14,9,0,0q�$��30��$	��Top=�$
��Left=�$��80��
���   �$��1��G� -   $��passBxPassword��$��
85,0,0,101q�$��Center=�$
��Left=�$	��193��$��FontAwesome)�
��� ���
������� G� PasswordChar$ *��	 � OverridesDefaultStyle	 .  
 G� SelectionBrush

 ��  �$��30��$��Bottom=�
���   �$��1���� -   $��lblfrgtPass��$��Forgot Password ?��$��
100,40,0,0q�
���   �$y�Hidden=�$��Normal&�$��FontAwesome)�$��Normal$�$��Normal"�$��28��$	��Top=�$
��Left=�$	��126��$��1���� -   $��btnStart��$��Start��$��
196,69,0,0q�$y�Hidden=�$��30��$	��Top=�$
��Left=�$��74�� � Cursor$
 Hand��$��FontAwesome)�
�������
���   �
���   �$��1���� -	   $��
lblLoading��$��Loading ...��$y�Hidden=�$
��Left=�$��77��$��30��$	��Top=�$��FontAwesome)�$��
116,42,0,0q�$��1���� -
   $��btnClose��$��X��$��22��$	��Top=�
���  �����	#00000000$��0q�$ Arrow�� � ForceCursor .   � ToolTip$ Close��$��	276,0,2,0q�
��������� -   $��CoursesList��$��14,176,14,82q�$y�Hidden=�$��2���� -    ��Name$ 	btnLogout��$��Logout��$��	30,69,0,0q�$y�Hidden=�$��30��$	��Top=�$
��Left=�$��74��$
 Hand��$��FontAwesome)�
�������
���   �
���   �$��1���� -   $ btnLogin��$��Login��$��
115,69,0,0q�$��30��$	��Top=�$
��Left=�$��74��$
 Hand��$��FontAwesome)�
�������
���   �
���   �$��1��