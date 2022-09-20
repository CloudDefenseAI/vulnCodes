#import <Foundation/Foundation.h>

int main(int argc, char *argv[]) {
    @autoreleasepool {
        NSString *path = @"/tmp/test";
        NSString *content = @"test";
        [content writeToFile:path atomically:YES encoding:NSUTF8StringEncoding error:nil];
    }
    return 0;
}
