// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/WholeBodyState.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_STATE__FUNCTIONS_H_
#define HALODI_MSGS__MSG__WHOLE_BODY_STATE__FUNCTIONS_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stdlib.h>

#include "rosidl_generator_c/visibility_control.h"
#include "halodi_msgs/msg/rosidl_generator_c__visibility_control.h"

#include "halodi_msgs/msg/whole_body_state__struct.h"

/// Initialize msg/WholeBodyState message.
/**
 * If the init function is called twice for the same message without
 * calling fini inbetween previously allocated memory will be leaked.
 * \param[in,out] msg The previously allocated message pointer.
 * Fields without a default value will not be initialized by this function.
 * You might want to call memset(msg, 0, sizeof(
 * halodi_msgs__msg__WholeBodyState
 * )) before or use
 * halodi_msgs__msg__WholeBodyState__create()
 * to allocate and initialize the message.
 * \return true if initialization was successful, otherwise false
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
bool
halodi_msgs__msg__WholeBodyState__init(halodi_msgs__msg__WholeBodyState * msg);

/// Finalize msg/WholeBodyState message.
/**
 * \param[in,out] msg The allocated message pointer.
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
void
halodi_msgs__msg__WholeBodyState__fini(halodi_msgs__msg__WholeBodyState * msg);

/// Create msg/WholeBodyState message.
/**
 * It allocates the memory for the message, sets the memory to zero, and
 * calls
 * halodi_msgs__msg__WholeBodyState__init().
 * \return The pointer to the initialized message if successful,
 * otherwise NULL
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
halodi_msgs__msg__WholeBodyState *
halodi_msgs__msg__WholeBodyState__create();

/// Destroy msg/WholeBodyState message.
/**
 * It calls
 * halodi_msgs__msg__WholeBodyState__fini()
 * and frees the memory of the message.
 * \param[in,out] msg The allocated message pointer.
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
void
halodi_msgs__msg__WholeBodyState__destroy(halodi_msgs__msg__WholeBodyState * msg);


/// Initialize array of msg/WholeBodyState messages.
/**
 * It allocates the memory for the number of elements and calls
 * halodi_msgs__msg__WholeBodyState__init()
 * for each element of the array.
 * \param[in,out] array The allocated array pointer.
 * \param[in] size The size / capacity of the array.
 * \return true if initialization was successful, otherwise false
 * If the array pointer is valid and the size is zero it is guaranteed
 # to return true.
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
bool
halodi_msgs__msg__WholeBodyState__Sequence__init(halodi_msgs__msg__WholeBodyState__Sequence * array, size_t size);

/// Finalize array of msg/WholeBodyState messages.
/**
 * It calls
 * halodi_msgs__msg__WholeBodyState__fini()
 * for each element of the array and frees the memory for the number of
 * elements.
 * \param[in,out] array The initialized array pointer.
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
void
halodi_msgs__msg__WholeBodyState__Sequence__fini(halodi_msgs__msg__WholeBodyState__Sequence * array);

/// Create array of msg/WholeBodyState messages.
/**
 * It allocates the memory for the array and calls
 * halodi_msgs__msg__WholeBodyState__Sequence__init().
 * \param[in] size The size / capacity of the array.
 * \return The pointer to the initialized array if successful, otherwise NULL
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
halodi_msgs__msg__WholeBodyState__Sequence *
halodi_msgs__msg__WholeBodyState__Sequence__create(size_t size);

/// Destroy array of msg/WholeBodyState messages.
/**
 * It calls
 * halodi_msgs__msg__WholeBodyState__Sequence__fini()
 * on the array,
 * and frees the memory of the array.
 * \param[in,out] array The initialized array pointer.
 */
ROSIDL_GENERATOR_C_PUBLIC_halodi_msgs
void
halodi_msgs__msg__WholeBodyState__Sequence__destroy(halodi_msgs__msg__WholeBodyState__Sequence * array);

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_STATE__FUNCTIONS_H_
