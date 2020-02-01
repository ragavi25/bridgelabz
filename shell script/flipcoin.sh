                    #!/bin/bash -x 
head=0
tail=0
	echo "enter how many times toss"
		read toss
	
	for ((i=1; i< toss; i++))
	do 
		if [ ${i} -lt 5 ]
		then
			echo "${i}"
			echo "head"
			let   head++
echo "${head}"
		else
			echo "${i}"
			echo "tail"
			let  tail++
		fi
			done
		
	pr_head=$(((${head}/${toss})*100))
	pr_tail=$(((${tail}/${toss})*100))
       
	echo "${pr_head}"
	 echo "${ptr_tail}"

