// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/BalanceMode.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__BALANCE_MODE__STRUCT_H_
#define HALODI_MSGS__MSG__BALANCE_MODE__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

/// Constant 'AUTOMATIC'.
enum
{
  halodi_msgs__msg__BalanceMode__AUTOMATIC = 0l
};

/// Constant 'DRIVING'.
enum
{
  halodi_msgs__msg__BalanceMode__DRIVING = 1l
};

/// Constant 'FOLLOW_ME'.
enum
{
  halodi_msgs__msg__BalanceMode__FOLLOW_ME = 2l
};

/// Constant 'FORCE_STATIONARY'.
enum
{
  halodi_msgs__msg__BalanceMode__FORCE_STATIONARY = 3l
};

/// Constant 'DISABLED'.
enum
{
  halodi_msgs__msg__BalanceMode__DISABLED = 84l
};

// Struct defined in msg/BalanceMode in the package halodi_msgs.
typedef struct halodi_msgs__msg__BalanceMode
{
  int32_t mode;
} halodi_msgs__msg__BalanceMode;

// Struct for a sequence of halodi_msgs__msg__BalanceMode.
typedef struct halodi_msgs__msg__BalanceMode__Sequence
{
  halodi_msgs__msg__BalanceMode * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__BalanceMode__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__BALANCE_MODE__STRUCT_H_
