#!/bin/sh
cd $TRAVIS_BUILD_DIR/MvcMovie
dotnet restore
cd ..
cd MvcMovie.Test
dotnet restore
dotnet test
