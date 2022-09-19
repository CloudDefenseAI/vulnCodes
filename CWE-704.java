// vulnerable code PoC for Incorrect Type Conversion or Cast which may lead to Denial of Service

import java.io.*;
import java.util.*;
import java.net.*;
import java.nio.*;
import java.nio.channels.*;
import java.nio.charset.*;
import java.nio.file.*;
import java.nio.file.attribute.*;
import java.util.concurrent.*;
import java.util.concurrent.atomic.*;
import java.util.concurrent.locks.*;
import java.util.function.*;

// typecast to int
public class test {
    public static void main(String[] args) {
        int i = 0;
        System.out.println(i);
    }
}

