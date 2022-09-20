#import <Foundation/Foundation.h>

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        // insert code here...
        NSLog(@"Hello, World!");
        NSString *password = @"password";
        NSString *username = @"username";
        NSString *keychainItemName = @"keychainItemName";
        NSString *keychainItemServiceName = @"keychainItemServiceName";
        NSMutableDictionary *keychainItem = [[NSMutableDictionary alloc] init];
        [keychainItem setObject:(__bridge id)kSecClassGenericPassword forKey:(__bridge id)kSecClass];
        [keychainItem setObject:keychainItemName forKey:(__bridge id)kSecAttrAccount];
        [keychainItem setObject:keychainItemServiceName forKey:(__bridge id)kSecAttrService];
        [keychainItem setObject:username forKey:(__bridge id)kSecAttrLabel];
        [keychainItem setObject:password forKey:(__bridge id)kSecValueData];
        [keychainItem setObject:(__bridge id)kSecAttrAccessibleWhenUnlocked forKey:(__bridge id)kSecAttrAccessible];
        [keychainItem setObject:(__bridge id)kSecAttrAccessibleWhenUnlockedThisDeviceOnly forKey:(__bridge id)kSecAttrAccessible];
        OSStatus status = SecItemAdd((__bridge CFDictionaryRef)keychainItem, NULL);
        if (status == errSecSuccess) {
            NSLog(@"Successfully added the %@/%@ keychain item.", keychainItemServiceName, keychainItemName);
        }
    }
    return 0;
}
