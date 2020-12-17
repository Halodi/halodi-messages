// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/ExtrinsicCalibrationInfo.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__STRUCT_H_
#define HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'sensor_transforms'
// Member 'link_infos'
#include "geometry_msgs/msg/transform_stamped__struct.h"
// Member 'joint_infos'
#include "halodi_msgs/msg/robot_joint_calibration_info__struct.h"

// constants for array fields with an upper bound
// sensor_transforms
enum
{
  halodi_msgs__msg__ExtrinsicCalibrationInfo__sensor_transforms__MAX_SIZE = 255
};
// link_infos
enum
{
  halodi_msgs__msg__ExtrinsicCalibrationInfo__link_infos__MAX_SIZE = 255
};
// joint_infos
enum
{
  halodi_msgs__msg__ExtrinsicCalibrationInfo__joint_infos__MAX_SIZE = 255
};

// Struct defined in msg/ExtrinsicCalibrationInfo in the package halodi_msgs.
typedef struct halodi_msgs__msg__ExtrinsicCalibrationInfo
{
  geometry_msgs__msg__TransformStamped__Sequence sensor_transforms;
  geometry_msgs__msg__TransformStamped__Sequence link_infos;
  halodi_msgs__msg__RobotJointCalibrationInfo__Sequence joint_infos;
} halodi_msgs__msg__ExtrinsicCalibrationInfo;

// Struct for a sequence of halodi_msgs__msg__ExtrinsicCalibrationInfo.
typedef struct halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence
{
  halodi_msgs__msg__ExtrinsicCalibrationInfo * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__STRUCT_H_
