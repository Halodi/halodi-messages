// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/RobotJointCalibrationInfo.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__STRUCT_H_
#define HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'frame_id'
#include "rosidl_generator_c/string.h"

// Struct defined in msg/RobotJointCalibrationInfo in the package halodi_msgs.
typedef struct halodi_msgs__msg__RobotJointCalibrationInfo
{
  rosidl_generator_c__String frame_id;
  double transmission_ratio;
  double measurement_offset;
} halodi_msgs__msg__RobotJointCalibrationInfo;

// Struct for a sequence of halodi_msgs__msg__RobotJointCalibrationInfo.
typedef struct halodi_msgs__msg__RobotJointCalibrationInfo__Sequence
{
  halodi_msgs__msg__RobotJointCalibrationInfo * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__RobotJointCalibrationInfo__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__STRUCT_H_
