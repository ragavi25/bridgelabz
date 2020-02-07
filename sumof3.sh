#!/bin/bash
arr=(1 2 3 4 5 6)
len=${#arr[@]}
for ((i=0;i<=$((len -2));i++))
do
for ((j=0;j<=$((len -1));j++))
do
for ((k=0;k<=$len;k++))
do
if[ $((arr[i] + arr[j] +arr[k]))== 0 ]
then
echo ${arr[i]}
fi
done
done
done
