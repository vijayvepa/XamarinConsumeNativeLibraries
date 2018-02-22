//
//  SampleClass.swift
//  SampleSwiftFramework
//
//  Created by VIJAY VEPAKOMMA on 2/20/18.
//  Copyright © 2018 VIJAY VEPAKOMMA. All rights reserved.
//

import UIKit

@objc(SampleClass)

public class SampleClass : NSObject
{
    @objc public func getValue() -> String
    {
        return "Value came from Swift.";
    }
    
   
}
