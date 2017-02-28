default: main

main: main.native

%.native:
	ocamlbuild -use-ocamlfind src/$@
	mv $@ $*
	./$*

.PHONY: main default
