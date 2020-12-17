// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/MotorStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__MOTOR_STATUS__STRUCT_H_
#define HALODI_MSGS__MSG__MOTOR_STATUS__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

/// Constant 'NO_ERROR'.
enum
{
  halodi_msgs__msg__MotorStatus__NO_ERROR = 0
};

/// Constant 'FAULTED'.
enum
{
  halodi_msgs__msg__MotorStatus__FAULTED = 1
};

/// Constant 'MISSED_DEADLINE'.
enum
{
  halodi_msgs__msg__MotorStatus__MISSED_DEADLINE = 2
};

/// Constant 'AUX_ENCODER_WARNING'.
enum
{
  halodi_msgs__msg__MotorStatus__AUX_ENCODER_WARNING = 3
};

/// Constant 'AUX_ENCODER_ERROR'.
enum
{
  halodi_msgs__msg__MotorStatus__AUX_ENCODER_ERROR = 4
};

/// Constant 'MOTOR_ENCODER_WARNING'.
enum
{
  halodi_msgs__msg__MotorStatus__MOTOR_ENCODER_WARNING = 5
};

/// Constant 'MOTOR_ENCODER_ERROR'.
enum
{
  halodi_msgs__msg__MotorStatus__MOTOR_ENCODER_ERROR = 6
};

/// Constant 'OVER_TEMPERATURE'.
enum
{
  halodi_msgs__msg__MotorStatus__OVER_TEMPERATURE = 7
};

/// Constant 'OVER_VOLTAGE'.
enum
{
  halodi_msgs__msg__MotorStatus__OVER_VOLTAGE = 8
};

/// Constant 'UNDER_VOLTAGE'.
enum
{
  halodi_msgs__msg__MotorStatus__UNDER_VOLTAGE = 9
};

/// Constant 'ETHERCAT_FAULT'.
enum
{
  halodi_msgs__msg__MotorStatus__ETHERCAT_FAULT = 10
};

/// Constant 'INVALID_STATE_TRANSITION'.
enum
{
  halodi_msgs__msg__MotorStatus__INVALID_STATE_TRANSITION = 11
};

// Include directives for member types
// Member 'joints'
#include "halodi_msgs/msg/joint_name__struct.h"

// constants for array fields with an upper bound
// joints
enum
{
  halodi_msgs__msg__MotorStatus__joints__MAX_SIZE = 2
};

// Struct defined in msg/MotorStatus in the package halodi_msgs.
typedef struct halodi_msgs__msg__MotorStatus
{
  uint8_t status_level;
  halodi_msgs__msg__JointName__Sequence joints;
  uint8_t motor_id;
  bool sto_enabled;
  bool over_temperature;
  uint32_t motor_serial_number;
  uint32_t driver_serial_number;
  bool motor_initialized;
  double motor_temperature;
  double driver_temperature;
  uint8_t motor_error;
} halodi_msgs__msg__MotorStatus;

// Struct for a sequence of halodi_msgs__msg__MotorStatus.
typedef struct halodi_msgs__msg__MotorStatus__Sequence
{
  halodi_msgs__msg__MotorStatus * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__MotorStatus__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__MOTOR_STATUS__STRUCT_H_
