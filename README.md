# :octocat: CSharp Simple Coding Katas
:monkey_face:[![Build Status](https://travis-ci.org/ernestohs/csharp.katas.simple.svg)](https://travis-ci.org/ernestohs/csharp.katas.simple)
:cloud:[![Build status](https://ci.appveyor.com/api/projects/status/e7o2ga07i68f2kj4?svg=true)](https://ci.appveyor.com/project/ernestohs/csharp-katas-simple)
:bar_chart: [![Coverage Status](https://coveralls.io/repos/github/ernestohs/csharp.katas.simple/badge.svg?branch=master)](https://ci.appveyor.com/project/ernestohs/csharp-katas-simple/build/tests)
:books: [![Inline docs](http://inch-ci.org/github/bfontaine/badges2svg.svg)](https://github.com/ernestohs/csharp.katas.simple/wiki)

## What is a code kata?
A code kata is an exercise in programming which helps a programmer hone their skills through practice and repetition.

## Simple katas
In any discipline we have a different level of exercises, in this set, you will find a collection of simple programming katas that I have tested and implemented.

## Katas Criteria

1. Can be implemented and tested in less than 10 minutes.
2. Follows the Single Responsibility Principle.
3. Illustrates a common but interesting programming problem.
4. The solution is well known.

# Hands-On

Here are all the details needed in order to *get* the code, *build*, *test* and contribute to this project.

## Get the source code

```sh
 git clone https://github.com/ernestohs/csharp.katas.simple.git
```

## Build

### Windows
You need to have installed [Visual Studio](https://www.visualstudio.com/downloads/), and execute this command on the [Developer Command Prompt for Visual Studio](https://msdn.microsoft.com/en-us/library/ms229859(v=vs.110).aspx).

![Build on Windows](https://github.com/ernestohs/csharp.katas.simple/blob/master/doc/img/CSharp.Basic.Katas.Windows.gif)

```sh
> msbuild
```

### Linux

You need to have installed [Mono](http://www.mono-project.com/), if you do not have it on your Linux box, you can check this [installation guide](http://www.mono-project.com/docs/getting-started/install/linux/); also you will need to instal [Make](https://www.gnu.org/software/make/) on your linux box.

![Build on Linux](https://github.com/ernestohs/csharp.katas.simple/blob/master/doc/img/CSharp.Basic.Katas.Linux.gif)

```sh
$ make
```
#### Notes

If the build process fails the most frequent issue is related with the Nuget restauration fo the packages, if so, you could fix the problem by importing the certificates into the machine store and not the user store, which is the default [(Learn more)](http://stackoverflow.com/questions/15181888/nuget-on-linux-error-getting-response-stream):

```sh
$ sudo mozroots --import --machine --sync
$ sudo certmgr -ssl -m https://go.microsoft.com
$ sudo certmgr -ssl -m https://nugetgallery.blob.core.windows.net
$ sudo certmgr -ssl -m https://nuget.org
```

### Test

#### Linux

```sh
$ make test
```

# License

[GNU GENERAL PUBLIC LICENSE                       Version 2](https://github.com/ernestohs/csharp.katas.simple/blob/master/LICENSE)
