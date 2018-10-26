#!/bin/bash

# Script criado para remover os diretorios /bin e /obj dos projetos, para que não ocorram os erros de 'FileNameTooLong'

clear

conta_remocao=0 #Iniciando contador de remocoes

for projeto in $(ls); do
	if [[ $projeto == "Introdução-a-programação" ]]
	then
		for x in $(ls "$projeto");do 
			for y in $(ls "$projeto/$x");do
				diretorio_obj="$projeto/$x/$y/obj"		
				diretorio_bin="$projeto/$x/$y/bin"		

				# Remove diretorios /obj 
				rm -r $diretorio_obj &> /dev/null
				obj_output=$? # 'obj_output' conterá o retorno do comando, para ver se foi executado com sucesso ou não
		
				if [[ $obj_output == 0 ]]
				then
					echo "'$diretorio_obj' Removido com sucesso!"
					conta_remocao=$conta_remocao+1;
				fi

				# Remove diretorios /bin
				rm -r $diretorio_bin &> /dev/null
				bin_output=$? # 'bin_output' conterá o retorno do comando, para ver se foi executado com sucesso ou não

				if [[ $bin_output == 0 ]]
				then
					echo "'$diretorio_bin' Removido com sucesso!"
					conta_remocao=$(($conta_remocao+1));
				fi
			done
		done
	else
		for x in $(ls);do 
			for y in $(ls "$x");do
				diretorio_obj="$x/$y/obj"		
				diretorio_bin="$x/$y/bin"		
				# Remove diretorios /obj 
				rm -r $diretorio_obj &> /dev/null
				obj_output=$? # 'obj_output' conterá o retorno do comando, para ver se foi executado com sucesso ou não

				if [[ $obj_output == 0 ]]
				then
					echo "'$diretorio_obj' Removido com sucesso!"
					conta_remocao=$conta_remocao+1;
				fi
					# Remove diretorios /bin
				rm -r $diretorio_bin &> /dev/null
				bin_output=$? # 'bin_output' conterá o retorno do comando, para ver se foi executado com sucesso ou não
				
				if [[ $bin_output == 0 ]]
				then
					echo "'$diretorio_bin' Removido com sucesso!"
				conta_remocao=$(($conta_remocao+1));
				fi
			done
		done
		fi 
done

# Saída

if [[ $conta_remocao == 0 ]]
then
	echo "Não há diretórios que precisem ser removidos"
else 
	echo "$conta_remocao remoções efetuadas!"
fi
