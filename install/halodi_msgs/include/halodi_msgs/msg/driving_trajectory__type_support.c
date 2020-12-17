// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/DrivingTrajectory.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/driving_trajectory__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/driving_trajectory__functions.h"
#include "halodi_msgs/msg/driving_trajectory__struct.h"


// Include directives for member types
// Member `trajectory_points`
#include "halodi_msgs/msg/driving_trajectory_point.h"
// Member `trajectory_points`
#include "halodi_msgs/msg/driving_trajectory_point__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__DrivingTrajectory__init(message_memory);
}

void DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_fini_function(void * message_memory)
{
  halodi_msgs__msg__DrivingTrajectory__fini(message_memory);
}

size_t DrivingTrajectory__rosidl_typesupport_introspection_c__size_function__DrivingTrajectoryPoint__trajectory_points(
  const void * untyped_member)
{
  const halodi_msgs__msg__DrivingTrajectoryPoint__Sequence * member =
    (const halodi_msgs__msg__DrivingTrajectoryPoint__Sequence *)(untyped_member);
  return member->size;
}

const void * DrivingTrajectory__rosidl_typesupport_introspection_c__get_const_function__DrivingTrajectoryPoint__trajectory_points(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__DrivingTrajectoryPoint__Sequence * member =
    (const halodi_msgs__msg__DrivingTrajectoryPoint__Sequence *)(untyped_member);
  return &member->data[index];
}

void * DrivingTrajectory__rosidl_typesupport_introspection_c__get_function__DrivingTrajectoryPoint__trajectory_points(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__DrivingTrajectoryPoint__Sequence * member =
    (halodi_msgs__msg__DrivingTrajectoryPoint__Sequence *)(untyped_member);
  return &member->data[index];
}

bool DrivingTrajectory__rosidl_typesupport_introspection_c__resize_function__DrivingTrajectoryPoint__trajectory_points(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__DrivingTrajectoryPoint__Sequence * member =
    (halodi_msgs__msg__DrivingTrajectoryPoint__Sequence *)(untyped_member);
  halodi_msgs__msg__DrivingTrajectoryPoint__Sequence__fini(member);
  return halodi_msgs__msg__DrivingTrajectoryPoint__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_member_array[3] = {
  {
    "look_ahead_distance",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__DrivingTrajectory, look_ahead_distance),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "K",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__DrivingTrajectory, K),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "trajectory_points",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__DrivingTrajectory, trajectory_points),  // bytes offset in struct
    NULL,  // default value
    DrivingTrajectory__rosidl_typesupport_introspection_c__size_function__DrivingTrajectoryPoint__trajectory_points,  // size() function pointer
    DrivingTrajectory__rosidl_typesupport_introspection_c__get_const_function__DrivingTrajectoryPoint__trajectory_points,  // get_const(index) function pointer
    DrivingTrajectory__rosidl_typesupport_introspection_c__get_function__DrivingTrajectoryPoint__trajectory_points,  // get(index) function pointer
    DrivingTrajectory__rosidl_typesupport_introspection_c__resize_function__DrivingTrajectoryPoint__trajectory_points  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_members = {
  "halodi_msgs__msg",  // message namespace
  "DrivingTrajectory",  // message name
  3,  // number of fields
  sizeof(halodi_msgs__msg__DrivingTrajectory),
  DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_member_array,  // message members
  DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_init_function,  // function to initialize message memory (memory has to be allocated)
  DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_type_support_handle = {
  0,
  &DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, DrivingTrajectory)() {
  DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, DrivingTrajectoryPoint)();
  if (!DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_type_support_handle.typesupport_identifier) {
    DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &DrivingTrajectory__rosidl_typesupport_introspection_c__DrivingTrajectory_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
