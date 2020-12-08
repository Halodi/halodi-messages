// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/BatteryStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__BATTERY_STATUS__STRUCT_H_
#define HALODI_MSGS__MSG__BATTERY_STATUS__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Struct defined in msg/BatteryStatus in the package halodi_msgs.
typedef struct halodi_msgs__msg__BatteryStatus
{
  uint8_t battery_status_level;
  double battery_voltage;
  double low_battery_voltage;
  double shutdown_battery_voltage;
} halodi_msgs__msg__BatteryStatus;

// Struct for a sequence of halodi_msgs__msg__BatteryStatus.
typedef struct halodi_msgs__msg__BatteryStatus__Sequence
{
  halodi_msgs__msg__BatteryStatus * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__BatteryStatus__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__BATTERY_STATUS__STRUCT_H_
