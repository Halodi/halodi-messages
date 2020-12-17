// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/JointName.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_NAME__STRUCT_H_
#define HALODI_MSGS__MSG__JOINT_NAME__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

/// Constant 'HIP_YAW'.
enum
{
  halodi_msgs__msg__JointName__HIP_YAW = 0l
};

/// Constant 'HIP_ROLL'.
enum
{
  halodi_msgs__msg__JointName__HIP_ROLL = 1l
};

/// Constant 'HIP_PITCH'.
enum
{
  halodi_msgs__msg__JointName__HIP_PITCH = 2l
};

/// Constant 'KNEE_PITCH'.
enum
{
  halodi_msgs__msg__JointName__KNEE_PITCH = 3l
};

/// Constant 'ANKLE_ROLL'.
enum
{
  halodi_msgs__msg__JointName__ANKLE_ROLL = 4l
};

/// Constant 'ANKLE_PITCH'.
enum
{
  halodi_msgs__msg__JointName__ANKLE_PITCH = 5l
};

/// Constant 'LEFT_SHOULDER_PITCH'.
enum
{
  halodi_msgs__msg__JointName__LEFT_SHOULDER_PITCH = 6l
};

/// Constant 'LEFT_SHOULDER_ROLL'.
enum
{
  halodi_msgs__msg__JointName__LEFT_SHOULDER_ROLL = 7l
};

/// Constant 'LEFT_SHOULDER_YAW'.
enum
{
  halodi_msgs__msg__JointName__LEFT_SHOULDER_YAW = 8l
};

/// Constant 'LEFT_ELBOW_PITCH'.
enum
{
  halodi_msgs__msg__JointName__LEFT_ELBOW_PITCH = 9l
};

/// Constant 'LEFT_ELBOW_YAW'.
enum
{
  halodi_msgs__msg__JointName__LEFT_ELBOW_YAW = 10l
};

/// Constant 'LEFT_WRIST_PITCH'.
enum
{
  halodi_msgs__msg__JointName__LEFT_WRIST_PITCH = 11l
};

/// Constant 'LEFT_WRIST_ROLL'.
enum
{
  halodi_msgs__msg__JointName__LEFT_WRIST_ROLL = 12l
};

/// Constant 'RIGHT_SHOULDER_PITCH'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_SHOULDER_PITCH = 13l
};

/// Constant 'RIGHT_SHOULDER_ROLL'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_SHOULDER_ROLL = 14l
};

/// Constant 'RIGHT_SHOULDER_YAW'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_SHOULDER_YAW = 15l
};

/// Constant 'RIGHT_ELBOW_PITCH'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_ELBOW_PITCH = 16l
};

/// Constant 'RIGHT_ELBOW_YAW'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_ELBOW_YAW = 17l
};

/// Constant 'RIGHT_WRIST_PITCH'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_WRIST_PITCH = 18l
};

/// Constant 'RIGHT_WRIST_ROLL'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_WRIST_ROLL = 19l
};

/// Constant 'NECK_PITCH'.
enum
{
  halodi_msgs__msg__JointName__NECK_PITCH = 20l
};

/// Constant 'LEFT_WHEEL'.
enum
{
  halodi_msgs__msg__JointName__LEFT_WHEEL = 21l
};

/// Constant 'RIGHT_WHEEL'.
enum
{
  halodi_msgs__msg__JointName__RIGHT_WHEEL = 22l
};

// Struct defined in msg/JointName in the package halodi_msgs.
typedef struct halodi_msgs__msg__JointName
{
  int32_t joint_id;
} halodi_msgs__msg__JointName;

// Struct for a sequence of halodi_msgs__msg__JointName.
typedef struct halodi_msgs__msg__JointName__Sequence
{
  halodi_msgs__msg__JointName * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__JointName__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__JOINT_NAME__STRUCT_H_
