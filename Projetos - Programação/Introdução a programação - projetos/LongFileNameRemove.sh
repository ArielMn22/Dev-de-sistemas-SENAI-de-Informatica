!#/bin/bash

for x in $(ls);do 
	for y in $(ls $x);do 
		rm -rf "$x/$y/obj/"
	done
done
