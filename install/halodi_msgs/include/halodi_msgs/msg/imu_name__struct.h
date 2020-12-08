// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/ImuName.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__IMU_NAME__STRUCT_H_
#define HALODI_MSGS__MSG__IMU_NAME__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

/// Constant 'pelvis_imu'.
enum
{
  halodi_msgs__msg__ImuName__pelvis_imu = 0l
};

// Struct defined in msg/ImuName in the package halodi_msgs.
typedef struct halodi_msgs__msg__ImuName
{
  int32_t imu_id;
} halodi_msgs__msg__ImuName;

// Struct for a sequence of halodi_msgs__msg__ImuName.
typedef struct halodi_msgs__msg__ImuName__Sequence
{
  halodi_msgs__msg__ImuName * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__ImuName__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__IMU_NAME__STRUCT_H_
