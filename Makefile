.PHONY: build test clean

build: clean
	xbuild /p:OS=mono /p:Configuration=Release simple.sln

test: build
	nunit-console ./tests/bin/Release/CSharp.Basic.Katas.Tests.dll

clean:
	xbuild /target:Clean simple.sln
	find . -type d -name 'bin' -o -name 'obj' | xargs rm -rvf 
