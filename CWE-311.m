#import <Foundation/Foundation.h>

int main(int argc, char *argv[]) {
    @autoreleasepool {
        NSString *path = @"/tmp/test";
        NSString *content = @"test";
        [content writeToFile:path atomically:YES encoding:NSUTF8StringEncoding error:nil];
        NSDictionary *attributes = @{NSFileProtectionKey: NSFileProtectionComplete};
        [[NSFileManager defaultManager] setAttributes:attributes ofItemAtPath:path error:nil];
    }
    return 0;
}
