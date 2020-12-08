// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/PassivityData.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__PASSIVITY_DATA__STRUCT_H_
#define HALODI_MSGS__MSG__PASSIVITY_DATA__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Struct defined in msg/PassivityData in the package halodi_msgs.
typedef struct halodi_msgs__msg__PassivityData
{
  double energy_packet;
  double energy_tank_level;
  double virtual_mass;
} halodi_msgs__msg__PassivityData;

// Struct for a sequence of halodi_msgs__msg__PassivityData.
typedef struct halodi_msgs__msg__PassivityData__Sequence
{
  halodi_msgs__msg__PassivityData * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__PassivityData__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__PASSIVITY_DATA__STRUCT_H_
