TFS Url Pinger
==============

Purpose
-------
A simple web service that implements the TFS Event subscriber method 'Notify' and attempts to access a list of URLs defined in the Web.config.

Installation
------------

Compile and place on a web server capable of serving ASMX files (i.e. IIS or Apache with mod_mono).

Edit the Web.config AppSetting 'PingUrls' with the comma deliminated list of urls you want to be "pinged" at checkin.

Setup the SOAP notification on the TFS alert to access the TFSUrlPinger address when CheckinEvent is raised.

License
-------

The MIT License

Copyright (c) 2010 Michael Letterle

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

