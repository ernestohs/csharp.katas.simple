.PHONY: build test clean

build: clean
	if [ ! -e .nuget/NuGet.exe ] ; \
	then \
	     wget http://nuget.org/nuget.exe -O ./.nuget/NuGet.exe ; \
	fi;
	xbuild /p:OS=mono /p:Configuration=Release simple.sln

test: build
	nunit-console ./tests/bin/Release/Basic.Katas.Tests.dll

clean:
	xbuild /target:Clean simple.sln
	find . -type d -name 'bin' -o -name 'obj' | xargs rm -rvf 
