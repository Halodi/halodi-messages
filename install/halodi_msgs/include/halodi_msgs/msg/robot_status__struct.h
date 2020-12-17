// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/RobotStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__ROBOT_STATUS__STRUCT_H_
#define HALODI_MSGS__MSG__ROBOT_STATUS__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__struct.h"
// Member 'battery_status'
#include "halodi_msgs/msg/battery_status__struct.h"
// Member 'joint_status'
#include "halodi_msgs/msg/joint_status__struct.h"
// Member 'motor_status'
#include "halodi_msgs/msg/motor_status__struct.h"

// constants for array fields with an upper bound
// joint_status
enum
{
  halodi_msgs__msg__RobotStatus__joint_status__MAX_SIZE = 30
};
// motor_status
enum
{
  halodi_msgs__msg__RobotStatus__motor_status__MAX_SIZE = 30
};

// Struct defined in msg/RobotStatus in the package halodi_msgs.
typedef struct halodi_msgs__msg__RobotStatus
{
  std_msgs__msg__Header header;
  uint8_t robot_status_level;
  halodi_msgs__msg__BatteryStatus battery_status;
  bool backpack_estop_enabled;
  bool wireless_estop_enabled;
  bool over_temperature;
  bool driving_disabled;
  halodi_msgs__msg__JointStatus__Sequence joint_status;
  halodi_msgs__msg__MotorStatus__Sequence motor_status;
  uint32_t runtime_since_start;
  uint32_t total_runtime;
  uint32_t numberOfRuns;
} halodi_msgs__msg__RobotStatus;

// Struct for a sequence of halodi_msgs__msg__RobotStatus.
typedef struct halodi_msgs__msg__RobotStatus__Sequence
{
  halodi_msgs__msg__RobotStatus * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__RobotStatus__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__ROBOT_STATUS__STRUCT_H_
