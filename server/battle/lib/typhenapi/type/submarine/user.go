// This file was generated by typhen-api

package submarine

import (
	"errors"
	"github.com/shiwano/submarine/server/battle/lib/typhenapi"
)

var _ = errors.New

// User is a kind of TyphenAPI type.
type User struct {
	Id   int64  `json:"id" msgpack:"id"`
	Name string `json:"name" msgpack:"name"`
}

// Coerce the fields.
func (t *User) Coerce() error {
	return nil
}

// Bytes creates the byte array.
func (t *User) Bytes(serializer typhenapi.Serializer) ([]byte, error) {
	if err := t.Coerce(); err != nil {
		return nil, err
	}

	data, err := serializer.Serialize(t)
	if err != nil {
		return nil, err
	}

	return data, nil
}
