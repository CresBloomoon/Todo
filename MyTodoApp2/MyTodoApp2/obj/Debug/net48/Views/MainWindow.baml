   M S B A M L   `   `   `  ????E  AMyTodoApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MyTodoApp2.ViewsMyTodoApp2.Views  5      =#clr-namespace:MyTodoApp2.ViewModelsMyTodoApp2.ViewModels  5      !    MyTodoApp2.Views.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors  5      V RLivet.Behaviors, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b0b1d3f711ef38cbW SLivet.Converters, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b0b1d3f711ef38cbV	 RLivet.Messaging, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b0b1d3f711ef38cbQ
 MLivet.Mvvm, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b0b1d3f711ef38cb4l&http://schemas.livet-mvvm.net/2011/wpf   	 
 5      ,vclr-namespace:MyTodoApp2.Views   	 
 5      2vm#clr-namespace:MyTodoApp2.ViewModels   	 
 5      -   5          ? Title$  TodoApp??5	      $	??525??5
      $	??350??5      .??5      ? .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgTodoList??5      $??8q?6'   $??16(?62   $
??Bold"?6@      AutoGenerateColumns$ False??6R      	CellStyle 5      ?? 5       ?? 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .?5      ??  ?? Property ? ?? ?? Value$ 0q?68   ?? 5       ?@?FocusVisualStyle 69   Z?  ?? Triggers 5      P? 5       P? Property ?@ 
IsSelected	 P? Value$
	 True??68   . ?5      ??  ? ??
 ?????6;   ?? 5       ? ??
 ?   ?6;   5      P? 5       ?@J?	IsFocused$	 False??67   P? 5       ?@ 	IsEditing$	 False??67   5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ CreationDate??6K      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6a      
IsReadOnly$
 True??6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ??  ?? Path$ CreationDate?6m   4  .System.Windows.Controls.DataGridCheckBoxColumn  5       $
 Done??6n   $ 80 6|   $ False??6?    6)   ?? $ IsDone? ?? UpdateSourceTrigger$ PropertyChanged=?6?     5!      $
 Todo??6C   $ * 6Q   $ False??6[    6%   ?? $
 Text?6[   5#      5$      5%      