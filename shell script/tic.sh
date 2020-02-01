#!/bin/bash
random()
{
return $(( RANDOM%9 ))
}
#i have created printboard
board=(1 1 1 1 1 1 1 1 1)
printboard()
{
echo "---|---|---"
echo "|"${board[0]} "|" ${board[1]} "|"${board[2]}
echo "---|---|---"
echo "|"${board[3]} "|" ${board[4]} "|"${board[5]}
echo "---|---|---"
echo "|"${board[6]} "|" ${board[7]} "|"${board[8]}
}
printboard
ComputerTurn(){
random
var=$?
if [ "${board[$var]}" = 1 ]
then
  board[$var]="X"
else
 ComputerTurn
fi
}
ComputerTurn 
printboard
#user turn
#we have to taken the value from the user input

UserTurn()
{
echo your turn enter the value
read value
#isLocation is empty!!
if [ "${arr[$value]}" = 1 ]
then
 board[$value]="O"
else
  UserTurn
fi

}
printboard
checkwinner()
{
 for ((i=0;i<=8;i++))
do
if [[ "${arr[0]}" = "X" && "${arr[1]}" = "X" && "${arr[2]}" = "X" || "${arr[3]}" = "X" && "${arr[4]}" = "X" && "${arr[5]}" = "X" || "${arr[6]}" = "X" && "${arr[7]}" = "X" && "${arr[8]}" = "X" || "${arr[0]}" = "X" &&
"${arr[3]}" = "X" && "${arr[6]}" = "X" ||"${arr[1]}" = "X" && "${arr[4]}" = "X" && "${arr[7]}" = "X" || "${arr[2]}" = "X" && "${arr[5]}" = "X" && "${arr[8]}" = "X" || "${arr[0]}" = "X" && "${arr[4]}" = "X" && "${arr[5]}" = "X" || "${arr[6]}" = "X" && "${arr[4]}" = "X" && 
"${arr[2]}" = "X" ]]
then
echo computer wins 
count=0 
flag=1
 elif [[ "${arr[0]}" = "O" && "${arr[1]}" = "O" && "${arr[2]}" = "O" ||"${arr[3]}" = "O" && "${arr[4]}" = "O" && "${arr[5]}" = "O" || "${arr[6]}" = "O" && "${arr[7]}" = "O" && "${arr[8]}" = "O" ||
"${arr[0]}" = "O" && "${arr[3]}" = "O" && "${arr[6]}" = "O" ||"${arr[1]}" = "O" && "${arr[4]}" = "O" && "${arr[7]}" = "O" || "${arr[2]}" = "O" && "${arr[5]}" = "O" && "${arr[8]}" = "O" || "${arr[0]}" = "O" && "${arr[4]}" = "O" && "${arr[8]}" = "O" || "${arr[6]}" = "O" && 
"${arr[4]}" = "O" && "${arr[2]}" = "O" ]]
 then 
echo
 user wins 
count=0 
flag=1 
fi
done
}
count=4
flag=0

while((count>0))
do

UserTurn
printboard
echo "........................."
checkwinner

if(($count!=0))
then

ComputerTurn
printboard
checkwinner
fi

count=$(($count-1))
done

if(($flag==0))
then
echo draw
fi

