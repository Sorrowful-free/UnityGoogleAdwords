//
//  adWordsiOSWrapper.m
//  adWordsiOSWrapper
//
//  Created by admin on 12.04.16.
//  Copyright © 2016 admin. All rights reserved.
//

#import "ACTReporter.h"

extern "C"
{
    NSString * ParseiOSString(const char * cString)
    {
        return [[NSString alloc] initWithUTF8String:cString];
    }
    
    void ConversionReporterRegisterReferrer(const char * clickUrl)
    {
        [ACTConversionReporter registerReferrer:[NSURL  URLWithString:ParseiOSString(clickUrl)]];
    }
    
    void ConversionReporterReportWithConversionId1(const char * conversionId,const char * label, const char * value,bool repeatable)
    {
        [ACTConversionReporter reportWithConversionID:ParseiOSString(conversionId) label:ParseiOSString(label) value:ParseiOSString(value) isRepeatable:repeatable];
    }
    
    void ConversionReporterReportWithConversionId2(const char * conversionId,const char * label, const char * value,const char* currencyCode,bool repeatable)
    {
        [ACTConversionReporter reportWithConversionID:ParseiOSString(conversionId)  label:ParseiOSString(label)  value:ParseiOSString(value)  currencyCode:ParseiOSString(currencyCode)  isRepeatable:repeatable];
    }
    
    void AutomatedUssageReporterDisableAutomatedUssage(const char * conversionId)
    {
        [ACTAutomatedUsageTracker disableAutomatedUsageReportingWithConversionID:ParseiOSString(conversionId)];
    }
    
    void AutomatedUssageReporterEnableAutomatedUssage(const char * conversionId)
    {
        [ACTAutomatedUsageTracker enableAutomatedUsageReportingWithConversionID:ParseiOSString(conversionId)];
    }
    
    void RemarketingReporterReportWithConversionId1(const char * conversionId)
    {
        [ACTRemarketingReporter reportWithConversionID:ParseiOSString(conversionId) customParameters:nil];
    }
    
    void RemarketingReporterReportWithConversionId2(const char * conversionId,const char * jsonParams)
    {
        NSStringEncoding encoding;
        NSData * jsonData = [ParseiOSString(jsonParams) dataUsingEncoding:encoding ];
        NSError * error = nil;
        NSDictionary * params = [NSJSONSerialization JSONObjectWithData:jsonData options:kNilOptions error:&error];
        if(error != nil)
        {
            NSLog(@"%@",[error description]);
        }
        [ACTRemarketingReporter reportWithConversionID:ParseiOSString(conversionId) customParameters:params];
    }
    
}

