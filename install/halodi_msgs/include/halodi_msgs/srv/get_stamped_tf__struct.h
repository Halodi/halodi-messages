// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:srv/GetStampedTF.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__SRV__GET_STAMPED_TF__STRUCT_H_
#define HALODI_MSGS__SRV__GET_STAMPED_TF__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'parent_frame'
// Member 'child_frame'
#include "rosidl_generator_c/string.h"

// Struct defined in srv/GetStampedTF in the package halodi_msgs.
typedef struct halodi_msgs__srv__GetStampedTF_Request
{
  double monotonic_stamp;
  rosidl_generator_c__String parent_frame;
  rosidl_generator_c__String child_frame;
} halodi_msgs__srv__GetStampedTF_Request;

// Struct for a sequence of halodi_msgs__srv__GetStampedTF_Request.
typedef struct halodi_msgs__srv__GetStampedTF_Request__Sequence
{
  halodi_msgs__srv__GetStampedTF_Request * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__srv__GetStampedTF_Request__Sequence;


// Constants defined in the message

// Include directives for member types
// Member 'stf'
#include "geometry_msgs/msg/transform_stamped__struct.h"

// Struct defined in srv/GetStampedTF in the package halodi_msgs.
typedef struct halodi_msgs__srv__GetStampedTF_Response
{
  bool ok;
  geometry_msgs__msg__TransformStamped stf;
} halodi_msgs__srv__GetStampedTF_Response;

// Struct for a sequence of halodi_msgs__srv__GetStampedTF_Response.
typedef struct halodi_msgs__srv__GetStampedTF_Response__Sequence
{
  halodi_msgs__srv__GetStampedTF_Response * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__srv__GetStampedTF_Response__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__SRV__GET_STAMPED_TF__STRUCT_H_
