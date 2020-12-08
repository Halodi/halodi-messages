// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/ImuMeasurement.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/imu_measurement__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/imu_measurement__functions.h"
#include "halodi_msgs/msg/imu_measurement__struct.h"


// Include directives for member types
// Member `imu`
#include "halodi_msgs/msg/imu_name.h"
// Member `imu`
#include "halodi_msgs/msg/imu_name__rosidl_typesupport_introspection_c.h"
// Member `orientation`
#include "geometry_msgs/msg/quaternion.h"
// Member `orientation`
#include "geometry_msgs/msg/quaternion__rosidl_typesupport_introspection_c.h"
// Member `angular_velocity`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3.h"
// Member `angular_velocity`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__ImuMeasurement__init(message_memory);
}

void ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_fini_function(void * message_memory)
{
  halodi_msgs__msg__ImuMeasurement__fini(message_memory);
}

static rosidl_typesupport_introspection_c__MessageMember ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_member_array[4] = {
  {
    "imu",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ImuMeasurement, imu),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "orientation",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ImuMeasurement, orientation),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "angular_velocity",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ImuMeasurement, angular_velocity),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "linear_acceleration",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ImuMeasurement, linear_acceleration),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_members = {
  "halodi_msgs__msg",  // message namespace
  "ImuMeasurement",  // message name
  4,  // number of fields
  sizeof(halodi_msgs__msg__ImuMeasurement),
  ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_member_array,  // message members
  ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_init_function,  // function to initialize message memory (memory has to be allocated)
  ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_type_support_handle = {
  0,
  &ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ImuMeasurement)() {
  ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ImuName)();
  ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Quaternion)();
  ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_member_array[3].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  if (!ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_type_support_handle.typesupport_identifier) {
    ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &ImuMeasurement__rosidl_typesupport_introspection_c__ImuMeasurement_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
