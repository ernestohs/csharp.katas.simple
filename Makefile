.PHONY: build test clean

build:
	xbuild /p:OS=mono simple.sln

test: build
	nunit-console ./tests/bin/Release/CSharp.Basic.Katas.Tests.dll

clean:
	xbuild /target:Clean simple.sln
